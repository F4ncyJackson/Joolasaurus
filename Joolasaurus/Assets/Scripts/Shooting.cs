using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public Transform myMuzzle;
	


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			bullet = Instantiate(bullet,myMuzzle.transform.position, Quaternion.identity);
		}
	}
}
