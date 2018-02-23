using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRegister : MonoBehaviour {

	private bool collided = false; // One score registration per spawn.
	private static AudioSource bounce;
	//-------------------------------------------------------------------------
	public void OnCollisionEnter(Collision col) {
		// Regardless, play bounce sound on contact.
		bounce = GetComponent<AudioSource> (); // Assign sound.
		bounce.volume = .25f;
		bounce.Play();
	}
	//-------------------------------------------------------------------------
    public void OnTriggerEnter(Collider obj) {
		/* Basketball scoring system. */

		// Only valid collisions will increment our score.
		if (obj.gameObject.name == "Register" && !collided) {
			ScoreKeeper.Instance.score += 2;
			Debug.Log ("Global Score: " + ScoreKeeper.Instance.score);
		}

		// Miss tracker for future game modes.
		else {
			if (obj.gameObject.name == "Ground" && !collided) {
				ScoreKeeper.Instance.miss += 1;
				Debug.Log ("Global Misses: " + ScoreKeeper.Instance.miss);
			}
		}
		collided = true; // Finally, toggle flag so we only register the first.
	}
	//-------------------------------------------------------------------------
}