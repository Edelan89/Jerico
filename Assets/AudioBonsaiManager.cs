using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBonsaiManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] audioClips;

    AudioSource audioSource;

    public static AudioBonsaiManager instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
        audioSource.clip = audioClips[0];
        audioSource.Play();
        InvokeRepeating(nameof(AudioTip), 30f, 15f);

    }
    void AudioTip()
    {
        audioSource.clip = audioClips[1];
        audioSource.Play();
    }

    public void LoseGame(out float length)
    {
        Debug.Log("LOSE GAME");

        audioSource?.Stop();
        CancelInvoke();
        audioSource.clip = audioClips[2];
        length = audioSource.clip.length;
        audioSource.Play();
    }
    public void WinGame(out float length)
    {
        Debug.Log("WIN GAME");

        audioSource?.Stop();
        CancelInvoke();
        audioSource.clip = audioClips[3];
        length = audioSource.clip.length;
        audioSource.Play();
    }
}
