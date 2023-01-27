using UnityEngine.UI;
using UnityEngine;
/*
    DataManager.cs controls the data within the options menu, using a slider to select speed, entering the players name for the end credits,
	and selecting whether to use whole numbers for the speed slider or fine tuning it with decimal point precision.
*/
public class DataManager : MonoBehaviour
{

	public Slider speedSlider; // slider ui element to select speed
	public Text speedText; // text ui element to display speed (foreward force)
	public InputField nameInput; // inputfield ui element for entering player name
	public Toggle wholeNumTog; // check box to switch between whole numbers or decimals on the speed slider

	// Static variables to store data for use throughout the project:
	public static string playerName = ""; // player name for credits scene
	public static float speed = 1000f; // speed value for use in level01 scene
	public static bool toggleState = false; // true or false for the whole number toggle in options menu

	// On start display player name in inputfield, set toggle to true or false, 
	// and set slider value to either defaults values or what the player set them too.
    void Start()
    {
		wholeNumTog.isOn = toggleState; // set toggle to default false or what the player changed it to.
		nameInput.text = playerName; // set inputfield to default empty string or the player input.
		speedSlider.value = speed; // set slider value to default 1000 or what the player set the value to.
       	Debug.Log(speed); // console message confirmation 
		Debug.Log(playerName); // console message confirmation
    }

	// Saves the slider value as speed to change the players speed in level01, updates text ui element to display speed value.
	public void SliderSetValue(){
		speed = speedSlider.value; // saves slider value
		speedText.text = speed.ToString(); // converts speed value to string for display
	}

	// Saves text typed in the inputfield ui element as the player's name.
	public void PlayerSetName(){
		playerName = nameInput.text.ToString(); // turns the text typed in the inputfield into a string and stores it.
	}

	// Saves the true or false state from the toggle ui elemnet.
	public void ToggleSetState(){
		toggleState = wholeNumTog.isOn; // saves wheteher the toggle is on - true or off - false.
	}

}
