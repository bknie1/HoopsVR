using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text points;
	// Use this for initialization
	void Start () {
		points = transform.Find ("Points").GetComponent<Text> ();
		points.text = ScoreKeeper.Instance.score.ToString();
		Debug.Log ("Displayed recent score.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
