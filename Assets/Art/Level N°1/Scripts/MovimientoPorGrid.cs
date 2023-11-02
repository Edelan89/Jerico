using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float tamanoCelda = 1.0f;
    private Vector2 posicionActual;
    private Vector2 direccionMovimiento = Vector2.zero;

    private void Start()
    {
        posicionActual = transform.position;
    }


    private void MoverObjeto()
    {
        Vector2 nuevaPosicion = posicionActual + direccionMovimiento * tamanoCelda;
        transform.position = nuevaPosicion;
        posicionActual = nuevaPosicion;
    }
}
