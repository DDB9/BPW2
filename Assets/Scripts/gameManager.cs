using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	public static gameManager instance = null;

	public Rigidbody player;
	public GameObject platform;
	public Canvas playerScreen;
	public AudioClip adPlop;

	public GameObject adProductPosOne;
	public GameObject adProductPosTwo;
	public GameObject adVirusPosOne;
	public GameObject adVirusPosTwo;

	private List<GameObject> adList = new List<GameObject>(2);
	public static bool adActive = false;
	private GameObject spawnedAd;
	private AudioSource source;

	void Start(){
		source = GetComponent<AudioSource>();

		adList.Add(adProductPosOne);
		adList.Add(adProductPosTwo);
		adList.Add(adVirusPosOne);
		adList.Add(adVirusPosTwo);
	}

	void Update(){
		playerController.canJump = !adActive;
	}

	void OnTriggerEnter(Collider other){
		source.PlayOneShot(adPlop, 1f);
		source.pitch = Random.Range(0.5f, 1.0f);

		Instantiate(platform, 
					platform.transform.position + Vector3.forward * 12, 
					platform.transform.rotation);

		Destroy(platform, 10f);
	
		spawnedAd = adList[Random.Range(0, adList.Count)];
		spawnedAd.SetActive(true);
		adActive = true;
	}
}
