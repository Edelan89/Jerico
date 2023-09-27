using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDControl : MonoBehaviour
{
    [SerializeField] private float maxCursorSpeed = 100f;
    [SerializeField] private float cursorSpeed = 50f;
    
    private float height;
    private float width;
   
    private Vector2 cursorPosition;
    private Rigidbody2D rb;


    private void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();
        var ancho = transform.position.x + (Screen.width / 2);

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
    }
}
