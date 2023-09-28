using System.Collections;
using UnityEngine;

public class Carta : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(35f);
        FadeManager.instance.StartFade();
        SceneTransitions.instance.GoToScene(LoadScenes.IsometricMaze, 1.5f);
    }
}
