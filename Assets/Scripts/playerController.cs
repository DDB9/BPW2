using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float movSpeed = 10;
	public float jumpForce = 5;
	public Rigidbody player;
	// Practice force on the gameobject to make it move.

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		player.velocity = new Vector3(0,0,movSpeed);

		if (Input.GetMouseButtonDown(0)){
			player.AddForce(new Vector3(0,1,0) * jumpForce * Time.deltaTime, ForceMode.Impulse);
		}
	}
}
