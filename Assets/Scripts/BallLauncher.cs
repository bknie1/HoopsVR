using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public GameObject basketball;
	public float velocity = 6.1f; // Min 3, Max 10?
	public float velocityMod = 1.0f;
	public float timer = 10.0f;
	public float time = 3.0f; // Time delta as velocity modifier.
	public float timeOffset = 0.1f; // % of time delta so it doesn't charge as quickly.
	Vector3 offset = new Vector3(0, .20f, 0);
	//------------------------------------------------------------------------------------------
	// Update is called once per frame
	// Spawns a ball and assigns direction based on user input.
	void Update () {
		// On button down, re-initialize delta time to 0. While down, increment delta time to a point.
		if (Input.GetButtonDown("Fire1") || GvrControllerInput.ClickButtonDown) measureTime();
		// On button up, stop incrementing delta time and use it to mod velocity.
		if (Input.GetButtonUp("Fire1") || GvrControllerInput.ClickButtonUp) spawnBall();
	}
	//------------------------------------------------------------------------------------------
	// Measure time between button down and button up to modify our ball velocity (charge).
	void measureTime() {
		time = 3.0f;
		while (time <= 10.0f) {
			time += Time.deltaTime;
			Debug.Log (time);
		}
	}
	//------------------------------------------------------------------------------------------
	// Creates a basketball, destroys after delay.
	void spawnBall() {
		// Create the ball.
		GameObject ball = Instantiate (basketball);
		ball.transform.position = this.transform.position - offset; // Sets ball position on camera.
		Rigidbody rb = ball.GetComponent<Rigidbody> ();

		// Spawn ball in direction of laser pointer. Reduce velocity.
		var controllerQ = GvrControllerInput.Orientation;

		// Use time delta to determine velocity.
		rb.velocity = controllerQ * Vector3.forward * ((time * timeOffset) * velocity) * velocityMod;

		// Destroys ball after a delay.
		Destroy(ball, timer);
	}
	//------------------------------------------------------------------------------------------
}