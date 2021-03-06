﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text points;
	//-------------------------------------------------------------------------
	void Start () {
		points = transform.Find ("Points").GetComponent<Text> ();
		try {
		points.text = ScoreKeeper.Instance.score.ToString();
		Debug.Log ("Displayed recent score.");
		} catch (MissingReferenceException mre) { Debug.Log ("Error: " + mre); }
	}
	//-------------------------------------------------------------------------
}
