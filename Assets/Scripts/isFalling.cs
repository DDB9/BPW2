using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isFalling : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		playerController.isFalling = false;
	}
}
