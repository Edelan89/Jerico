using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public static SceneTransitions instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void GoToScene(LoadScenes sceneName, float timeToWait)
    {
        Invoke(sceneName.ToString(), timeToWait);
    }
    private void Menu()
    {
        if(ProgressManager.instance != null) ProgressManager.instance.ResetProgress();
        SceneManager.LoadScene("Menu");
    }
    private void Letter()
    {
        SceneManager.LoadScene("Letter");
    }
    private void IsometricMaze()
    {
        SceneManager.LoadScene("IsometricMaze");
    }
    private void Casettera()
    {
        SceneManager.LoadScene("Casettera");
    }
    private void Bonsai()
    {
        SceneManager.LoadScene("Bonsai");
    }
    private void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
}


public enum LoadScenes
{
    Menu, Letter, IsometricMaze, Casettera, Bonsai, Controles
}