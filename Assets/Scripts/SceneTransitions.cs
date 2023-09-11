using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitions : MonoBehaviour
{
    [SerializeField] private GameObject blackFade;

    static SceneTransitions instance;

    private void Awake()
    {
        instance = this;
    }
    public static void _PlayButton()
    {
        instance.PlayButton();
    }

    public static void _EndOfCasset()
    {
        instance.EndOfCasset();
    }

    private void EndOfCasset()
    {
        blackFade.GetComponent<Animator>().SetTrigger("PressPlay");
        Invoke("LoadMenuScene", 1f);
    }

    private void PlayButton()
    {
        blackFade.GetComponent<Animator>().SetTrigger("PressPlay");
        Invoke("LoadGameScene", 1.5f);
    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    private void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
