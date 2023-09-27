using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitions : MonoBehaviour
{
    [SerializeField] private GameObject blackFade;

    public static SceneTransitions instance;

    private string TriggerStartFade = "StartFade";

    public static string LoadMenu => nameof(LoadMenuScene);
    public static string LoadGame => nameof(LoadGameScene);
    private void Awake()
    {
        instance = this;
    }

    public void GoToScene(String sceneName, float timeToWait)
    {
        blackFade.GetComponent<Animator>().SetTrigger(TriggerStartFade);
        Invoke(sceneName, timeToWait);
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
