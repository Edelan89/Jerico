using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTexto : MonoBehaviour
{
    [Range(1f, 5f)]
    [SerializeField] float speed;
    // SerializedField: para que la barra se vea.
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}

//upadate: renderiza en pantalla todo lo que esta sucediendo. se ejecuta 1 vez por frame