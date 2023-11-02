using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimietosObjetoPrueba : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust the speed as needed

    void Update()
    {
        // Check for left movement (A key)
        if (Input.GetKey("a"))
        {
            MoveLeft();
        }
        // Check for right movement (D key)
        else if (Input.GetKey("d"))
        {
            MoveRight();
        }
    }

    void MoveLeft()
    {
        // Move the object to the left
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    void MoveRight()
    {
        // Move the object to the right
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
