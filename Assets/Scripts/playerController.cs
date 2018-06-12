﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public static playerController instance = null;

	public float movSpeed = 10;
	public float jumpForce = 5;
	public Rigidbody player;
	private bool isFalling = false;
	public int jumpTimer = 60;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		player.velocity = new Vector3(0, 0, movSpeed); // Moves the player forward

		if (Input.GetMouseButtonDown(0) && isFalling == false){
			player.AddForce(0, jumpForce, 0);
			
			// Try to lerp the jump. Looks a little nicer.
		} 
	}
}