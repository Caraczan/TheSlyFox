using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;

    public Transform abyss; 
    public Transform respawnPoint;
    public GameObject playerPrefab;

    private void Awake(){
    	instance = this;
    }
    public void Respawn() {
    	GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
    } 
}