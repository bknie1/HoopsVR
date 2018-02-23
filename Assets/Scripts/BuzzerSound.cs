using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzerSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource buzzer = GetComponent<AudioSource> ();
		buzzer.volume = .5f;
		buzzer.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
