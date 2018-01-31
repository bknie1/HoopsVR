using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Load the next scene.
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Scene currentScene = SceneManager.GetActiveScene ();

			switch(currentScene.name) {
			case "01_Menu":
				Debug.Log ("Loading game.");
				SceneManager.LoadScene ("02_Game");
				break;
			case "03_GameOver":
				Debug.Log ("Loading main menu.");
				SceneManager.LoadScene ("01_Menu");
				break;
			default:
				Debug.Log("Invalid scene."); // Due diligence.
				break;
			}
		}
	}
}