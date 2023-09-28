using UnityEngine;
using System.Collections;

public class BonsaiSceneManager : MonoBehaviour
{
    public static BonsaiSceneManager instance;

    GameObject cursor;
    private void Awake()
    {
        instance = this;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private IEnumerator Start()
    {
        cursor = CursorController.instance.gameObject;
        cursor.SetActive(false);
        yield return new WaitForSeconds(8.5f);
        cursor.SetActive(true);
    }
    public void Win()
    {
        AudioBonsaiManager.instance.WinGame(out float length);
        FadeManager.instance.StartFade(length - 1f);
        SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, length + 1f);
    }
    public void Lose()
    {
        AudioBonsaiManager.instance.LoseGame(out float length);
        FadeManager.instance.StartFade(length - 1f);
        SceneTransitions.instance.GoToScene(LoadScenes.Menu, length + 1f);
    }
}