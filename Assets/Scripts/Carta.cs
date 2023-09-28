using System.Collections;
using UnityEngine;

public class Carta : MonoBehaviour
{
    private IEnumerator Start()
    {
        Cursor.visible = true;
        Cursor.lockState= CursorLockMode.None;

        yield return new WaitForSeconds(40f);
        FadeManager.instance.StartFade();
        SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 1.5f);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeManager.instance.StartFade();
            SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 1.5f);
        }
    }
}
