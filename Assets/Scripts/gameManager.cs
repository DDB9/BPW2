using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	public GameObject platform;

	void OnTriggerEnter(Collider other){
		Instantiate(platform, platform.transform.position + Vector3.forward * 12, platform.transform.rotation);
		Destroy(platform, 20f);
	
		adSpawner.adProductPosOne.SetActive(true);
	}
}
