using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{
    public bool WalkmanCompleted { get; private set; } = false;

    public bool BonsaiCompleted { get; private set; } = false;

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
        WalkmanCompleted = true;
    }

    public void VisitBonsai()
    {
        BonsaiCompleted = true;
    }
}
