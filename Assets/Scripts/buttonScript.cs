using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {

	public GameObject ad;

	public void exitAd(){
		ad.SetActive(false);
	}
}
