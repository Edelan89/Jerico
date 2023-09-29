using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Vector2 walkmanSpawnPosition; 
    [SerializeField] private Vector2 bonsaiSpawnPosition;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject triggerStartCell;
    [SerializeField] private GameObject doorAudioSource;
    [SerializeField] private GameObject firstStepAudioSource;
    void Start()
    {
        LoadScene();
    }

    public void LoadScene()
    {
        bool walkman = ProgressManager.instance.isWalkmanCompleted;
        bool bonsai = ProgressManager.instance.isBonsaiCompleted;
        
        
        if (walkman && !bonsai)
        {
            firstStepAudioSource.SetActive(false);
            doorAudioSource.SetActive(false);
            player.transform.position = walkmanSpawnPosition;
            AudioMazeManager.instance.PlayClipIndex(1); // Veamos como no hardcodear esto despues
        }
        else if (bonsai)
        {
            firstStepAudioSource.SetActive(false);
            doorAudioSource.SetActive(false);
            player.transform.position = bonsaiSpawnPosition;
            AudioMazeManager.instance.PlayClipIndex(3);
            triggerStartCell.SetActive(true);
        }
    }
}
