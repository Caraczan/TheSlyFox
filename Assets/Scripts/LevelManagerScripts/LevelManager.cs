using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;

    public Transform abyss; 
    public Transform respawn_point;
    public GameObject player_prefab;
    public Text scene_text;
    private void Awake(){
    	instance = this;
        scene_text.text = SceneManager.GetActiveScene().name;
    }
    public void Respawn() {
    	GameObject player = Instantiate(player_prefab, respawn_point.position, Quaternion.identity);
    } 
    
}