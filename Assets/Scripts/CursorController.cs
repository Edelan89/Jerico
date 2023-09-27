using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField] private float maxCursorSpeed = 100f;
    [SerializeField] private float cursorSpeed = 50f;
    [SerializeField] private Sprite tijeraCerrada;
    [SerializeField] private Sprite tijeraAbierta;

    private float height;
    private float width;

    private Vector2 cursorPosition;
    private Rigidbody2D rb;
    private Collider2D collider2d;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

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
            collider2d.enabled = true;
            spriteRenderer.sprite = tijeraCerrada;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            collider2d.enabled = false;
            spriteRenderer.sprite = tijeraAbierta;
        }
    }
}
