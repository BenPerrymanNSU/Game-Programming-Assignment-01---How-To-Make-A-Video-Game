using UnityEngine;
/*
    AssetsEndTrigger.cs is the script for controlling the end of level trigger, calls the GameManager to display ui and animation.
*/
public class AssetsEndTrigger : MonoBehaviour
{

    public GameManagerScript gameManager; // accesses the GameManager script

    // when the player moves through the trigger, it will call GameManager script to invoke CompleteLevel.
    void OnTriggerEnter(){
        gameManager.CompleteLevel(); // Triggers level complete ui and animation.
    }
}
