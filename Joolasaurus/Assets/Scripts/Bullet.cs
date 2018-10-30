using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public Rigidbody2D rb; 
	public float shootForce;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.right * shootForce;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
