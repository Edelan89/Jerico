using UnityEngine;
using UniRx;

public class ShakeCursor : MonoBehaviour
{

    [SerializeField] private float stressPower;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            stressPower = 0;
        }
    }
}
