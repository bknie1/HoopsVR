using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour {
	private int score;
	// Use this for initialization
	void Start () {
	}
	//-------------------------------------------------------------------------
	// Update is called once per frame
	void Update () {
	}
	//-------------------------------------------------------------------------
	void OnCollisionEnter(Collision collisionInfo) {
		score++;
		Debug.Log("Score: " + score);
	}
}