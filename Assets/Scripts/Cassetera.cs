using UnityEngine;
using UnityEngine.SceneManagement;

public class Cassetera : MonoBehaviour
{
    AudioSource cassetera => GetComponent<AudioSource>();
    [SerializeField] private Animator animatorCassetera;
    [SerializeField] private Animator animatorFade;

    private bool isPlaying = false;

    public void PressPlay()
    {
        if(isPlaying) return;
        cassetera.Play();
        isPlaying = true;
        Amiga.ShutUpFriend();
        animatorCassetera.SetTrigger("PressButton");
        Invoke(nameof(IrAlMenu), 23f);
    }

    void IrAlMenu()
    {
        FadeManager.instance.FadeOut();
        SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 1.5f);
    }
}
