using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float movSpeed = 10;
	public Rigidbody rigBod;
	// Practice force on the gameobject to make it move.

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		rigBod.GetComponent<Rigidbody>().velocity = new Vector3(0,0,movSpeed);
	}
}
