using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	public Rigidbody2D rb;
	

	public float runSpeed = 40f;

	[SerializeField] bool grounded = true;
	[SerializeField] float jumpForce;
	private Collider2D myCollider;

	void start() 
	{
		rb = GetComponent<Rigidbody2D>();
		
	}
	//movement
	void Update () 
	{
		if(!grounded && rb.velocity.y == 0)
		{
			grounded = true;
		}

		rb.velocity = new Vector2(runSpeed, rb.velocity.y);


		if(Input.GetButtonDown("Jump"))
		{
			if(grounded == true)
			{
				rb.AddForce(transform.up*jumpForce);
				grounded = false;
			}
		}
	}
}
