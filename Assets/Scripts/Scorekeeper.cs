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
	public float levelTimer = 15.0f; // Set on New Game.

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
		// Game end detection. Misses or flat timer, depending on game mode?
		if (ScoreKeeper.Instance.levelTimer <= 0) {
			SceneManager.LoadScene ("03_GameOver");
		}

		// Only time active play.
		Scene currentScene = SceneManager.GetActiveScene ();
		if (currentScene.name == "02_Game") {
			levelTimer -= Time.deltaTime; // How much time it has taken to render ea. frame.
			Debug.Log ("Time remaining: " + levelTimer);
		}
	}
}
