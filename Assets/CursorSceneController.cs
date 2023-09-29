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
        Cursor.visible = isCursorInThisSceneActive;
        if (cursor != null)
            cursor.SetActive(isSpecialCursorInThisSceneActive);
    }

}
