using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsSceneController : MonoBehaviour
{
    private static bool isChange;
    [SerializeField] private GameObject letterMusicSource;
    private void Start()
    {
        Invoke("CambiarScene", 5f);
    }

    private void CambiarScene()
    {
        FadeManager.instance.FadeOut();
        Destroy(GameObject.Find("LetterMusicSource"));
        SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 2f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isChange)
        {
            CancelInvoke();
            CambiarScene();
            isChange = true;
        }
    }
}
