using System.Collections;
using UnityEngine;

public class Carta : MonoBehaviour
{
    [SerializeField] private GameObject audioSource;
    private IEnumerator Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        yield return new WaitForSeconds(40f);

        DontDestroyOnLoad(audioSource);
        ChangeScene();
    }

    private static void ChangeScene()
    {
        FadeManager.instance.StartFade();
        SceneTransitions.instance.GoToScene(LoadScenes.Controles, 1.5f);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(audioSource);
            ChangeScene();
        }
    }
}
