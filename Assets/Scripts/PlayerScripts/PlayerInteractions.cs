using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerInteractions : MonoBehaviour {

	[SerializeField] private int diamonds = 0;
	[SerializeField] private Text diamondText;	
	private void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.CompareTag("Abyss")) {
			// Destroy(gameObject);
			// LevelManager.instance.Respawn();
			transform.position = LevelManager.instance.respawn_point.position; 
		}

		if(col.gameObject.CompareTag("Enemy")) {
			// TODO: On enemy hit player should get hit and receive it,
			// Destroy(gameObject);
			// LevelManager.instance.Respawn();
			transform.position = LevelManager.instance.respawn_point.position; 
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Collectible")
		{
			Destroy(collision.gameObject);
			diamonds += 4;
			diamondText.text = "Score: " + diamonds.ToString();
		}
	}
}
