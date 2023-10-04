using UnityEngine;

public class SwitchCanvasActiveStatus : MonoBehaviour
{
    [SerializeField] private GameObject optionCanvas;
    [SerializeField] private GameObject creditCanvas;
    [SerializeField] private GameObject mainMenuCanvas;

    static SwitchCanvasActiveStatus instance;

    private static GameObject _optionCanvas => instance.optionCanvas;
    private static GameObject _creditCanvas => instance.creditCanvas;
    private static GameObject _mainMenuCanvas => instance.mainMenuCanvas;

    private void Awake()
    {
        if (!(instance == null)) 
            Destroy(instance);

        instance = this;
    }

    public static void SwitchActiveStatusOptionsCanvas()
    {
        SwitchActiveStatusMainMenuCanvas();
        _optionCanvas.SetActive(!_optionCanvas.activeSelf);
    }
    public static void SwitchActiveStatusCreditCanvas()
    {
        SwitchActiveStatusMainMenuCanvas();
        _creditCanvas.SetActive(!_creditCanvas.activeSelf);
    }
    public static void SwitchActiveStatusMainMenuCanvas()
    {
        _mainMenuCanvas.SetActive(!_mainMenuCanvas.activeSelf);
    }
}