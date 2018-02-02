using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRegister : MonoBehaviour {

	private bool collided = false; // One score registration per spawn.
	//-------------------------------------------------------------------------
    public void OnTriggerEnter(Collider obj) {
		/* Basketball scoring system. */

		// Only valid collisions will increment our score.
		if (obj.gameObject.name == "Register" && !collided) {
			ScoreKeeper.Instance.score += 2;
			Debug.Log ("Global Score: " + ScoreKeeper.Instance.score);
		}
		// However, if we collide with anything else first... it's a miss!
		// Reminder: After n misses, the game ends.

		/*
		else {
			if (obj.gameObject.name == "Ground" && !collided) {
				ScoreKeeper.Instance.miss += 1;
				Debug.Log ("Global Misses: " + ScoreKeeper.Instance.miss);
			}
		}
		*/

		AudioSource bounce = GetComponent<AudioSource> ();
		bounce.volume = .5f;
		bounce.Play();

		collided = true; // Finally, toggle flag so we only register the first.
	}
}