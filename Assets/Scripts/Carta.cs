using UnityEngine;

public class Carta : MonoBehaviour
{
    private void Start()
    {
        Invoke(nameof(GoToMaze), 35f);
    }

    private static void GoToMaze()
    {
        FadeManager.instance.gameObject.SetActive(false);
        SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 1.5f);
    }
}
