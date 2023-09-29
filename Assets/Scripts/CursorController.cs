using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorController : MonoBehaviour
{
    [SerializeField] private float maxCursorSpeed = 100f;
    [SerializeField] private float cursorSpeed = 50f;
    [SerializeField] private Animator anim;
    [SerializeField] private LayerMask uiMask;
    private float height;
    private float width;

    private Vector2 cursorPosition;
    private Rigidbody2D rb;
    private Collider2D collider2d;
    private SpriteRenderer spriteRenderer;

    public static CursorController instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        height = Camera.main.orthographicSize * 2.0f;
        width = height * Screen.width / Screen.height;
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 movimiento = new(horizontal, vertical);

        rb.AddForce(movimiento * Time.deltaTime * cursorSpeed);

        if (rb.velocity.magnitude > maxCursorSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxCursorSpeed;
        }

        cursorPosition = transform.position;

        cursorPosition.x = Mathf.Clamp(cursorPosition.x, -width / 2, width / 2);
        cursorPosition.y = Mathf.Clamp(cursorPosition.y, -height / 2, height / 2);

        transform.position = cursorPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Le ponemos click para hacer animacion generica, y que los distintos cursores puedan tener animaciones distintas
            if(anim) anim.SetTrigger("Click");
            else
            {
                var pos = Camera.main.WorldToScreenPoint(transform.position);
                var pointerEventData = new PointerEventData(EventSystem.current) { position = pos };
                //Ray ray = Camera.main.ScreenPointToRay();
                List<RaycastResult> results = new List<RaycastResult>();
                EventSystem.current.RaycastAll(pointerEventData, results);

                if (results.Count > 0)
                {
                    IPointerClickHandler clickHandler = results[0].gameObject.GetComponent<IPointerClickHandler>();
                    if(clickHandler != null) clickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
                }
            }
        }
    }
}
