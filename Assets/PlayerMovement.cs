using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{	
	public CharacterController2D controller;
    public Animator animator; 
	public float runSpeed = 40f;

	private float horizontalMove = 0f;
	private bool jump = false;
	private bool crouch = false;
    private bool canDoubleJump;

     
    // Update is called once per frame
    void Update() {
    	horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        // Debug.Log(controller.Grounded);

        
    	if(Input.GetButtonDown("Jump")){
			jump = true;
            animator.SetBool("isJumping", true);
    	}

    	if(Input.GetButtonDown("Crouch")){
    		crouch = true;
    	} else if (Input.GetButtonUp("Crouch")) {
    		crouch = false;
    	}
    }

    public void OnLanding(){
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate(){
    	controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        if(!canDoubleJump){
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        }
    	jump = false;
    }
}
