using UnityEngine;
/*
    PlayerCollision.cs script controls the players state after hitting an obstacle.
    On collision with an obstacle the player is place in a "GameOver" state meaning they no longer move and wait to be reset.
*/
public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // access to PlayerMovement.cs

    // Calculates collision when players hit an object with tag "obstacle".
    void OnCollisionEnter(Collision collisionInfo){
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false; // Disables player movement
            FindObjectOfType<GameManagerScript>().GameOver(); // loads "GameOver" to reset
        }
    }

}
