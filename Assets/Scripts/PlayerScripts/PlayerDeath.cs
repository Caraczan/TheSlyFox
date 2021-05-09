using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
	private void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.CompareTag("Abyss")) {
			Destroy(gameObject);
			LevelManager.instance.Respawn();
		}

		if(col.gameObject.CompareTag("Enemy")) {
			// TODO: On enemy hit player should get hit and receive it,
			Destroy(gameObject);
			LevelManager.instance.Respawn();
		}
	}
}
