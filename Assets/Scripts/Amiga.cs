using UnityEngine;
using UnityEngine.U2D.IK;

public class Amiga : MonoBehaviour
{
    AudioSource amiga => gameObject.GetComponent<AudioSource>();

    public static Amiga instance;

    [SerializeField] private AudioClip clip2;
    static AudioSource _amiga => instance.amiga;
    private bool clipAFinished = false;

    private void Awake()
    {
        instance = this;
    }
    
    public static void ShutUpFriend()
    {
        instance.clipAFinished = true;
        _amiga.Stop();
        instance.CancelInvoke();
    }


    void FixedUpdate()
    {
        if (!clipAFinished && !amiga.isPlaying)
        {
            clipAFinished = true;
            amiga.clip = clip2;
            InvokeRepeating("PlayLoop", 15f, 15f);
        }
    }
    void PlayLoop()
    {
        amiga.Play();
    }

}
