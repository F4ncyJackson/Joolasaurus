using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	private Rigidbody2D rb;

	public CharacterController2D controller;
	
	float horizontalMove = 0f;
	bool jump = false;

	public float runSpeed = 40f;


	// Use this for initialization

	//movement
	void Update () {

		//input for moving

		horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed;
		
		if(Input.GetButtonDown("Jump"))
		{
			jump = true;
		}

	}

	void FixedUpdate()
	{
		//move our character

		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}

}
