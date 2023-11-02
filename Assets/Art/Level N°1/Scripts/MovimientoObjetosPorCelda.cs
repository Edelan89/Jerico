using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDiscretoObjeto : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float tamanoCelda = 1.0f;

    private Vector2 posicionActual;
    private Vector2 direccionMovimiento = Vector2.right; // Cambiar a Vector2.left para mover hacia la izquierda
    private bool movimientoActivado = false; // Agregamos un booleano para activar/desactivar el movimiento

    private void Start()
    {
        posicionActual = transform.position;
    }

    private void Update()
    {
        if (movimientoActivado)
        {
            MoverObjeto();
        }
    }

    private void MoverObjeto()
    {
        Vector2 nuevaPosicion = posicionActual + direccionMovimiento * tamanoCelda;
        transform.position = nuevaPosicion;
        posicionActual = nuevaPosicion;
    }

    public void ActivarMovimiento()
    {
        movimientoActivado = true;
    }
}
