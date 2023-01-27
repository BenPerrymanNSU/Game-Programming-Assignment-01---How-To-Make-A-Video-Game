using UnityEngine;
using UnityEngine.UI;
/*
    Score.cs displays the players postion along the z axis as points, starting from 0.
*/
public class Score : MonoBehaviour
{

    public Transform player; // player position
    public Text scoreText; // text ui element

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); // sets text ui element to the players position on the z axis as a string to display.
    }
}
