using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Launcher : MonoBehaviour {

	public GameObject basketball;
	public float velocity = 10.5f;
	public float timer = 10.0f;
	Vector3 offset = new Vector3(0, .20f, 0);
	//------------------------------------------------------------------------------------------
	// Use this for initialization
	void Start () {

	}
	//------------------------------------------------------------------------------------------
	// Update is called once per frame
	// Spawns a ball and assigns direction based on user input.
	void Update () {
		//if (Input.GetMouseButtonDown (0)) Spawn(); // On left click, spawn ball.
		if (Input.GetButtonDown("Fire1")) Spawn_Ball();
	}
	//------------------------------------------------------------------------------------------
	// Creates a basketball, destroys after delay.
	void Spawn_Ball() {
		Camera camera = GetComponentInChildren<Camera>();
		GameObject ball = Instantiate (basketball);
		ball.transform.position = this.transform.position - offset; // Sets ball position on camera.
		Rigidbody rb = ball.GetComponent<Rigidbody> ();
		// Launches ball in camera direction.
		rb.velocity = camera.transform.rotation * Vector3.forward * velocity;
		Destroy(ball, timer);
	}
	//------------------------------------------------------------------------------------------
}