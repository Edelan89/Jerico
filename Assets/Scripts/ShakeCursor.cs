using UnityEngine;

public class ShakeCursor : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] private float timeWithoutInput;
    [SerializeField] private float maxTimeWithoutInput;
    [SerializeField] private float stressPower;

    StressReceiver stressReceiver;

    private void Start()
    { 
        stressReceiver = GetComponent<StressReceiver>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(rb.velocity.magnitude == 0)
        {
            timeWithoutInput += Time.deltaTime;
        }
        else
        {
            timeWithoutInput = 0;
        }
        if (timeWithoutInput >= maxTimeWithoutInput)
        {
            stressReceiver.InduceStress(stressPower);
            //timeWithoutInput = 0;
        }
    }

}