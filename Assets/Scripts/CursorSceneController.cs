using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSceneController : MonoBehaviour
{
    [SerializeField] private bool isCursorInThisSceneActive;
    [SerializeField] private bool isSpecialCursorInThisSceneActive;
    [SerializeField] private GameObject cursor;


    void Start()
    {
        if(!isCursorInThisSceneActive) Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = isCursorInThisSceneActive;
        if (cursor != null)
            cursor.SetActive(isSpecialCursorInThisSceneActive);
    }

}
