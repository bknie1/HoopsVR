using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Global score singleton. */

public class ScoreKeeper : MonoBehaviour {

	private static ScoreKeeper _instance;
	public int score; // Our single score tracker.
	public int miss = 0;

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
		if (miss >= 3) {
			SceneManager.LoadScene ("03_GameOver");
		}
	}
}
