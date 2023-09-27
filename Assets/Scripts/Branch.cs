using UnityEngine;

public class Branch : MonoBehaviour
{
    [SerializeField] private LayerMask cursor;

    [SerializeField] private bool isCritical;


    private void Start()
    {
        if(!isCritical) TreeManager.instance.branchQuantity++;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OBJETO ENTRANTE:" + collision.gameObject.layer);

        if (collision.gameObject.layer != 7) return;

        GetComponent<Rigidbody2D>().gravityScale = 1f;
        TreeManager.instance.CutBranch(isCritical);
    }
}