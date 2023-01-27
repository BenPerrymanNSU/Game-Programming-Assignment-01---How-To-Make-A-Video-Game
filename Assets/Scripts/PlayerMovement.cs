using UnityEngine;
/*
    PlayerMovement.cs controls the player's red cube, the speed, turning speed, controls, and position reset.
*/
public class PlayerMovement : MonoBehaviour
{

    // This is a reference to the Rigidbody component called "PlayerRb"
    public Rigidbody PlayerRb;

    // default speed values
    public float forwardForce = 2000f; // forward speed
    public float sidewaysForce = 500f; // left and right speed

    // At start of scene, calls DataManager for the static speed value selected in the options menu scene.
    void Start()
    {
       forwardForce = DataManager.speed; // sets forward speed to value selected in options menu via slider
       Debug.Log(DataManager.speed); // console message confirmation
    }

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force on the z-axis
        PlayerRb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force selected on the z-axis

        if (Input.GetKey("d")){
            PlayerRb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // shifts cube right
        }

        if (Input.GetKey("a")){
            PlayerRb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // shifts cube left
        }

        if (PlayerRb.position.y < -1f){
            FindObjectOfType<GameManagerScript>().GameOver(); // resets player position to starting position through GameManager
        }
    }
}
