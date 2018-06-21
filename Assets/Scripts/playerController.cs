using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

	public static playerController instance = null;

	public float movSpeed = 10;
	public float jumpForce = 5;
	public Rigidbody player;
	public static bool canJump = true;
	public static bool canDuck = true;
	public static bool isFalling = false;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		player.velocity = new Vector3(0, player.velocity.y, movSpeed); // Moves the player forward

		if (Input.GetMouseButtonDown(0) && canJump == true && isFalling == false){
			player.AddForce(0, jumpForce, 0, ForceMode.Impulse);
			isFalling = true;
			movSpeed = 5; // This is pretty shitty, fix it.
		} 

		if (Input.GetMouseButton(1) && canDuck == true){
			player.transform.localScale = new Vector3(-0.6f, 0.4f, -0.6f); // If player presses the right mouse button, the player ducks.
		} else {
			player.transform.localScale = new Vector3(-0.6f, 0.6f, -0.6f); // Otherwise it keeps it's original size.
		}

		if (Input.GetKeyDown(KeyCode.Escape)){
			movSpeed = 0;	// If the escape button is pushed, the menu comes up.
		}
	}
}
