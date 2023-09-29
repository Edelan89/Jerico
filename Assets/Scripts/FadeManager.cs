﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour
{
    [SerializeField] private GameObject fade;

    [Tooltip("Este string es el nombre del trigger que tendrá.")]
    [SerializeField] private string TriggerStartFade;

    [SerializeField] private Image fadeImage;
    [SerializeField] private float fadeInLength = 1f;
    [SerializeField] private float fadeOutLength = 1f;

    public static FadeManager instance;

    private void Awake()
    {
       instance = this;
    }

    private void Start()
    {
        FadeIn();
    }

    public void FadeIn()
    {
        StartCoroutine(Fade(0f, fadeInLength));
    }
    
    public void FadeOut()
    {
        StartCoroutine(Fade(1f, fadeOutLength));
        //fade.GetComponent<Animator>().SetTrigger(TriggerStartFade);
    }
    public void FadeOut(string Trigger)
    {
        StartCoroutine(Fade(1f, fadeOutLength));
        fade.GetComponent<Animator>().SetTrigger(Trigger);
    }
    public void FadeOut(float timeToWait)
    {
        Invoke(nameof(FadeOut), timeToWait);
    }
    
    public IEnumerator Fade(float endValue,  float duration)
    {
        float elapsedTime = 0;
        float startValue = fadeImage.color.a;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startValue, endValue, elapsedTime / duration);
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, newAlpha);
            yield return null;
        }
    }
}
