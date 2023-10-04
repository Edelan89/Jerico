using UnityEngine;

public class Branch : MonoBehaviour
{
    [SerializeField] private LayerMask cursor;

    [SerializeField] private bool isCritical;

    private bool WasCutted = false;

    private void Start()
    {
        if(!isCritical) TreeManager.instance.branchQuantity++;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OBJETO ENTRANTE:" + collision.gameObject.layer);

        if (collision.gameObject.layer != 7 || WasCutted) return;

        WasCutted = true;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        GetComponent<Rigidbody2D>().gravityScale = 1f;
        TreeManager.instance.CutBranch(isCritical);
    }
}