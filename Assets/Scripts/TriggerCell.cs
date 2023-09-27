using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCell : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FadeManager.instance.StartFade();
            SceneTransitions.instance.GoToScene(LoadScenes.Bonsai, 2f);
        }
        print(collision.tag);
    }
}
