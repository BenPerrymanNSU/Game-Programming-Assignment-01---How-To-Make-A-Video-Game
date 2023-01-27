using UnityEngine;
using UnityEngine.SceneManagement;
/*
    Menu.cs controls the menu buttons, loading each menu or returning to the main menu.
*/
public class Menu : MonoBehaviour
{
    // Button to load the first level.
    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // main menu is 0, + 1 leads to level 1
    }

    // Button to load instructions menu scene.
    public void InstructMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4); // main menu is 0, + 4 leads to the instruction menu
    }

    // Button to load options menu scene.
    public void OptionsMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5); // main menu is 0, + 5 leads to the options menu
    }

    // Button to return to the main menu.
    public void ReturnBack(){
        SceneManager.LoadScene(0); // returns to scene the main menu, scene 0.
    }
}
