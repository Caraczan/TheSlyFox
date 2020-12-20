using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController2D : MonoBehaviour
{

    private float playerSpeed = 0.01f;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(playerSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-playerSpeed, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, playerSpeed);
        }
    }
}
