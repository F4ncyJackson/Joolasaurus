using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public Rigidbody2D rb; 
	public float shootForce;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.forward * shootForce * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
