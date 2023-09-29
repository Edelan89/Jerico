using UnityEngine;

public class BonsaiTriggerCell : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        if (ProgressManager.instance.isWalkmanCompleted)
        {
            FadeManager.instance.StartFade();
            SceneTransitions.instance.GoToScene(LoadScenes.Bonsai, 2f);
        }
        else
        {
            AudioMazeManager.instance.PlayClipIndex(2);
        }
    }
}
