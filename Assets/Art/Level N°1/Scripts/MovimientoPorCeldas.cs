using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float tamanoCelda = 1.0f;
    private Vector2 posicionActual;
    private Vector2 direccionMovimiento = Vector2.zero;

    private void Start()
    {
        posicionActual = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoverIzquierda();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MoverDerecha();
        }
    }

    private void MoverIzquierda()
    {
        direccionMovimiento = Vector2.left;
        MoverJugador();
    }

    private void MoverDerecha()
    {
        direccionMovimiento = Vector2.right;
        MoverJugador();
    }

    private void MoverJugador()
    {
        Vector2 nuevaPosicion = posicionActual + direccionMovimiento * tamanoCelda;
        transform.position = nuevaPosicion;
        posicionActual = nuevaPosicion;
    }
}
