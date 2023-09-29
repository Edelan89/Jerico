using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsSceneController : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);

        FadeManager.instance.StartFade();
        SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 2f);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FadeManager.instance.StartFade();
            SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 2f);
        }
    }
}
