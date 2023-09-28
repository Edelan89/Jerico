public class AudioMazeManager : AudioManager
{
    public static AudioMazeManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlayClip()
    {
        audioSource.clip = audioClips[2];
        audioSource.Play();
    }
}