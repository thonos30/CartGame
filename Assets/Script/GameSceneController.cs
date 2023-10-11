using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   


public class GameSceneController : MonoBehaviour
{
    public Text gameText;
    private float gameTimer;
    public GameObject checkpointContainer; 
    public int checkpointId;
    private int currentCheckpoint = -1;
    // Start is called before the first frame update
    void Start()
    
    {
        foreach (CheckpointController checkpoint in
        checkpointContainer.GetComponentsInChildren
        <CheckpointController>()) 

        {
            checkpoint.onHitByPlayer = (int checkpointId) =>
            OnReachCheckpoint(checkpointId);
        }
        if (checkpointId == currentCheckpoint + 1)
        {
            currentCheckpoint++;
        }
        if (checkpointId == 0 && currentCheckpoint == 3)
        {
            Debug.Log ("Lap finished");
            currentCheckpoint = 0;
        }
    }

    // Update is called once per frame
    void Update()
    
    {
        gameTimer += Time.deltaTime;
        gameText.text = "Time: " + Mathf.Floor(gameTimer);
    }
    void OnReachCheckpoint (int checkpointId)
    {
        Debug.Log (checkpointId);
    }
    
}
