using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	private Rigidbody2D rb;
	private bool shouldJump;
	private bool canJump;


	public float speed;
	public float jumpPower;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	//movement
	void Update () {

		//walking/running
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.AddForce (movement * speed);

		//Jumping Key
		if(Input.GetButtonDown("Jump"))
		{
			shouldJump = true;
			canJump = false;
		}	
	}

	void FixedUpdate()
	{
		if (shouldJump) 
		{
			//Jumping
			rb.AddForce (Vector3.up * jumpPower, ForceMode2D.Impulse);
			shouldJump = false; 
		} 
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		canJump = true;
	}
}
