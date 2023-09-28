using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsCanvasController : MonoBehaviour
{

    private string CanvasString = "CanvasControles";
    private void Start()
    {
        if(PlayerPrefs.GetInt(CanvasString) == 0)
        {
            PlayerPrefs.SetInt(CanvasString, 1);
            gameObject.SetActive(true);
        }
        else if(PlayerPrefs.GetInt(CanvasString) == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
