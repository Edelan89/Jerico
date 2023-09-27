using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SetTileMap : MonoBehaviour
{
    private void Awake()
    {
        GraphicsSettings.transparencySortAxis = new(0, 1, -.26f);
    }
}
