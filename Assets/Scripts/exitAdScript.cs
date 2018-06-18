using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitAdScript : MonoBehaviour {

	public GameObject ad;

	public void exitAd(){
		ad.SetActive(false);
		gameManager.adActive = false;
		playerController.canJump = true;

	}
}
