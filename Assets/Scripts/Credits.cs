using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
    Credits.cs is used for the credits scene, it sets a text ui element to displat the players name from the option menu,
    a quit game button, and a return to main menu button.
*/
public class Credits : MonoBehaviour
{

    public Text nameText; // text ui element

    // On start change text ui element to display the stored players name.
    public void Start(){
        if (DataManager.playerName == ""){
            DataManager.playerName = "You, the player!"; // if the player name inputfield is left empty it will change the stored blank to this message.
        }

        nameText.text = DataManager.playerName; // sets the text ui element to display the players name.
    }

    // Button for quitting the application.
    public void Quit(){
        Debug.Log("Quit"); // console message confirmation
        Application.Quit(); // closes the application
    }

    // Button to load the main menu.
    public void ReturnBack(){
        SceneManager.LoadScene(0); // Loads scene 0 - the main menu.
    }
}
