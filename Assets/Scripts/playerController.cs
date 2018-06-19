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
	public static bool isFalling = false;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		player.velocity = new Vector3(0, 0, movSpeed); // Moves the player forward

		if (Input.GetMouseButtonDown(0) && canJump == true && isFalling == false){
			player.AddForce(0, jumpForce, 0);
			isFalling = true;
			
			// Try to lerp the jump. Looks a little nicer.
		} 

		if (Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);	// If the escape button is pushed, the menu comes up.
		}
	}
}
