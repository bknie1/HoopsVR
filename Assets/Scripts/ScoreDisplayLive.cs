using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayLive : MonoBehaviour
{
	Text points;
	//-------------------------------------------------------------------------
	void Update ()
	{
		points = transform.Find ("Points").GetComponent<Text> ();
		try {
			points.text = ScoreKeeper.Instance.score.ToString();
		} catch (MissingReferenceException mre) { Debug.Log ("Error: " + mre); }
	}
	//-------------------------------------------------------------------------
}