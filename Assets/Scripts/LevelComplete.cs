using UnityEngine;
using UnityEngine.SceneManagement;
/*
    LevelComplete.cs is a script dedicated to loading the next scene after the level is complete.
*/
public class LevelComplete : MonoBehaviour
{
    // loads the next scene.
    public void LoadNextLevel (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // current scene + 1 to get to the next scene.
    }
}
