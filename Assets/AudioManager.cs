using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] protected AudioClip[] audioClips;

    protected AudioSource audioSource;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayClipIndex(int index)
    {
        audioSource.clip = audioClips[index];
        audioSource.Play();
    }
}
