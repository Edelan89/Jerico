using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Vector2 walkmanSpawnPosition; 
    [SerializeField] private Vector2 bonsaiSpawnPosition;
    [SerializeField] private GameObject player;
    
    
    void Start()
    {
        LoadScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        bool walkman = ProgressManager.instance.isWalkmanCompleted;
        bool bonsai = ProgressManager.instance.isBonsaiCompleted;
        
        if (walkman && !bonsai)
        {
            player.transform.position = walkmanSpawnPosition;
            AudioMazeManager.instance.PlayClipIndex(1); // Veamos como no hardcodear esto despues
        }
        else if (bonsai)
        {
            player.transform.position = bonsaiSpawnPosition;
            AudioMazeManager.instance.PlayClipIndex(3);
        }
    }
}
