using UnityEngine;

public class StartTriggerCell : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        FadeManager.instance.FadeOut();
        SceneTransitions.instance.GoToScene(LoadScenes.Menu, 3f);
    }
}