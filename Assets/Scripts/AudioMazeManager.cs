public class AudioMazeManager : AudioManager
{
    public static AudioMazeManager instance;

    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
}