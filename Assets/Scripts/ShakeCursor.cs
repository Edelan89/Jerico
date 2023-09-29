using UnityEngine;
using UniRx;

public class ShakeCursor : MonoBehaviour
{

    [SerializeField] private float stressPower;
    [SerializeField] private bool constantStress = false;
    private Rigidbody2D rb;
    private StressReceiver stressReceiver;
    private float magnitude;


    private void Start()
    {
        stressReceiver = GetComponent<StressReceiver>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (constantStress) stressReceiver.InduceStress(stressPower);
        else
        {
            if (magnitude > rb.velocity.magnitude || magnitude == 0)
            {
                stressPower += Time.deltaTime * .1f;
            }
            else
            {
                stressPower -= Time.deltaTime * 2f;
            }

            stressPower = Mathf.Clamp01(stressPower);

            if (stressPower != 0)
            {
                stressReceiver.InduceStress(stressPower);
            }

            magnitude = rb.velocity.magnitude;
        }
    }
}
