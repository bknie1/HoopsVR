using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Load the next scene.
		SceneManager.LoadScene("02_Game");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
