using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] protected AudioClip[] audioClips;

    protected AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
