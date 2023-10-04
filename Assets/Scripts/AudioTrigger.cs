using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        GetComponent<AudioSource>().Play(); // Podriamos mover todo a un audio manager en vez de tener muchas audio source
        GetComponent<Collider2D>().enabled = false;
    }
}
