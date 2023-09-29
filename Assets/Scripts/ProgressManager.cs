using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{
    public bool isWalkmanCompleted { get; private set; } = false;

    public bool isBonsaiCompleted { get; private set; } = false;

    public static ProgressManager instance;

   

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }

    public void VisitWalkman()
    {
        isWalkmanCompleted = true;
    }

    public void VisitBonsai()
    {
        isBonsaiCompleted = true;
    }
}
