﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	private int score = 0;
	//-------------------------------------------------------------------------
	// Use this for initialization
	void Start () {

	}
	//-------------------------------------------------------------------------
	// Update is called once per frame
	void Update () {

	}
	//-------------------------------------------------------------------------
    public void OnCollisionEnter(Collision collisionInfo) {
	   score++;
       Debug.Log("Global Score: " + score);
	}
}