using UnityEngine;
using UniRx;

public class ShakeCursor : MonoBehaviour
{

    [SerializeField] private float stressPower;
    [SerializeField] private float maxStressPower;
    [SerializeField] private bool constantStress = false;
    [SerializeField] private float stressIncreaseRate;
    [SerializeField] private float stressDecreaseRate;
    private Rigidbody2D rb;
    private StressReceiver stressReceiver;
    private CursorController cursorController;
    private float magnitude;


    private void Start()
    {
        stressReceiver = GetComponent<StressReceiver>();
        cursorController = GetComponent<CursorController>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (constantStress)
        {
            stressReceiver.InduceStress(stressPower);
            return;
        }
        
        
        if (!cursorController.InputPressed)
        {
            stressPower += Time.deltaTime * stressIncreaseRate;
        }
        else
        {
            stressPower -= Time.deltaTime * stressDecreaseRate;
        }

        stressPower = Mathf.Clamp(stressPower, 0, maxStressPower);

        if (stressPower != 0)
        {
            stressReceiver.SetTrauma(stressPower);
        }

        //magnitude = rb.velocity.magnitude;
    }
}
