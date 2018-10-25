using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	private Rigidbody2D rb;


	public float speed;
	public float jumpPower;
	public bool isJumping;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "ground") 
		{
			isJumping = false;
		}
			
	}
	//movement
	void Update () {

		//walking/running
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.AddForce (movement * speed);
	

		if(Input.GetButtonDown ("Jump")){ 
			if(isJumping == false)
			{
				isJumping = true;
				rb.AddForce(Vector2.up * jumpPower);
			}
		}
	}

}
