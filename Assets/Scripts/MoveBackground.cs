using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {
	[SerializeField]
	private Transform centerBackground;
    // Update is called once per frame
    void Update() {
    	if(transform.position.x >= centerBackground.position.x + 38.37f)
    		centerBackground.position = new Vector2(centerBackground.position.x + 38.37f, transform.position.y);
        if(transform.position.x <= centerBackground.position.x - 38.37f)
    		centerBackground.position = new Vector2(centerBackground.position.x - 38.37f, transform.position.y);
    }
}
