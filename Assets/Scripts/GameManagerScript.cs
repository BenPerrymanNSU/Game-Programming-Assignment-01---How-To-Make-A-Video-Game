using UnityEngine;
using UnityEngine.SceneManagement;
/*
    GameManagerScript.cs controls when the player dies or has complete a level, resets current scene upon death with delay.
*/
public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false; // whether or not the player collided and died
    public float restartDelay = 1f; // player respawn wait timer
    public GameObject CompleteLevelUI; // level complete text

    // upon level complete, display console message and activate level complete ui and animation.
    public void CompleteLevel(){
        Debug.Log("Level Won!"); // console message confirmation
        CompleteLevelUI.SetActive(true); // level complete ui and animation
    }

    // upon player death, update whether or not the game has ended, displat console message, and trigger restart with delay.
    public void GameOver(){
        if (gameHasEnded == false){
            gameHasEnded = true; // set to true to confirm death
            Debug.Log("Game Over"); // console message confirmation
            Invoke("Restart", restartDelay); // triggers Restart (V V below V V) and delays it by 1 sec.
        }
    }

    // upon death reloads the level scene.
    void Restart (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // grabs current scene again
    }

}
