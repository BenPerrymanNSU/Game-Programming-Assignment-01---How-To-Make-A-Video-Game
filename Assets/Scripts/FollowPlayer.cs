using UnityEngine;
/*
    FollowPlayer.cs is the script dedicated to making the main camera follow the player.
*/
public class FollowPlayer : MonoBehaviour
{
    public Transform player; //player position
    public Vector3 offset; // xyz postion offset from player position

    // Update is called once per frame
    void Update()
    {
       transform.position = player.position + offset; // Moves main camera along with player, offset to be a certain distance from the player
    }
}
