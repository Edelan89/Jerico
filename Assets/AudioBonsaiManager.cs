using UnityEngine;

public class AudioBonsaiManager : AudioManager
{
    public static AudioBonsaiManager instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        audioSource.loop = false;
        audioSource.clip = audioClips[0];
        audioSource.Play();
        InvokeRepeating(nameof(AudioTip), 30f, 15f);

    }
    private void AudioTip()
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
