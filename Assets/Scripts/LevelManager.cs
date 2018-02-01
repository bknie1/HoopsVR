using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	//-------------------------------------------------------------------------
	public void NewGame() {
		ScoreKeeper.Instance.score = 0; // Reset
		ScoreKeeper.Instance.miss = 0; // Reset
		Debug.Log("Reset values.");
		Debug.Log ("Loading New Game.");
		SceneManager.LoadScene ("02_Game");
	}
	//-------------------------------------------------------------------------
	public void GameOver() {
		Debug.Log ("Loading Game Over.");
		SceneManager.LoadScene ("03_GameOver");
	}
	//-------------------------------------------------------------------------
	public void MainMenu() {
		Debug.Log ("Loading Menu.");
		SceneManager.LoadScene ("01_Menu");
	}
	//-------------------------------------------------------------------------
	public void ExitGame() {
		Debug.Log ("Quitting game.");
		Application.Quit ();
	}
}