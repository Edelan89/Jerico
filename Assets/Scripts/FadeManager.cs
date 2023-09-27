using UnityEngine;

public class FadeManager : MonoBehaviour
{
    [SerializeField] private GameObject fade;

    [Tooltip("Este string es el nombre del trigger que tendrá.")]
    [SerializeField] private string TriggerStartFade;

    public static FadeManager instance;

    private void Awake()
    {
       instance = this;
    }
    
    public void StartFade()
    {
        fade.GetComponent<Animator>().SetTrigger(TriggerStartFade);
    }
    public void StartFade(string Trigger)
    {
        fade.GetComponent<Animator>().SetTrigger(Trigger);
    }
}
