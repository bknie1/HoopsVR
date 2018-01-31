using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Global score singleton. */

public class ScoreKeeper : MonoBehaviour {

	private static ScoreKeeper _instance;
	public int score = 0; // Our single score tracker.
	public int miss = 0; // Our miss counter.
	const int MISS_MAX = 3; // Our miss limit. Here for easy modification.

	//-------------------------------------------------------------------------
	public static ScoreKeeper Instance {
		get { return _instance; }
	}
	//-------------------------------------------------------------------------
	void Awake() {
		if (_instance == null) {
			_instance = this;
		} else Object.Destroy (this);
	}
	//-------------------------------------------------------------------------
	void Update() {
		// New game detection.
		Scene currentScene = SceneManager.GetActiveScene();
		if (currentScene.name == "01_Menu") {
			score = 0; // Reset
			miss = 0; // Reset
			Debug.Log("Reset values.");
		}
		// Game end detection.
		if (ScoreKeeper.Instance.miss >= 3) {
			SceneManager.LoadScene ("03_GameOver");
		}
	}
}
