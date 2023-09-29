using UnityEngine;
using UnityEngine.SceneManagement;

public class Cassetera : MonoBehaviour
{
    AudioSource cassetera => GetComponent<AudioSource>();
    [SerializeField] private Animator animatorCassetera;
    [SerializeField] private Animator animatorFade;

    public void PressPlay()
    {
        cassetera.Play();
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
