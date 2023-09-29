using UnityEngine;

public class CasseteraTriggerCell : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        if (ProgressManager.instance.isWalkmanCompleted) return;
        ProgressManager.instance.VisitWalkman();
        FadeManager.instance.StartFade();
        SceneTransitions.instance.GoToScene(LoadScenes.Casettera, 2f);
    }
}
