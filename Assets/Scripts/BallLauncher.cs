using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public GameObject basketball;
	public float velocity = 6.1f; // 0.5
	public float velocityMod = 1.0f; // 10.0
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
		if (Input.GetButtonDown("Fire1") || GvrControllerInput.ClickButtonDown) spawnBall();
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

		rb.velocity = controllerQ * Vector3.forward * velocity * velocityMod;

		Debug.Log ("Ball spawned.");

		// Destroys ball after a delay.
		Destroy(ball, timer);
	}
	//------------------------------------------------------------------------------------------
}