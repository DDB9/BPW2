using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adSpawner : MonoBehaviour {

	public static adSpawner instance = null;

	public GameObject adProductPosOne;
	public GameObject adProductPosTwo;

	/*
	public List<Vector3> adSpawnPoints = new List<Vector3>(4);
	public Vector3 adSpawnpoint1;
	public Vector3 adSpawnpoint2;
	public Vector3 adSpawnpoint3;
	public Vector3 adSpawnpoint4;

	public float minX = 0;
	public float maxX = 10;
	public float minY = 0;
	public float maxY = 10;
	public float minZ = -3;
	public float maxZ = 0;

	public Sprite adProducts;
	*/

 	void Start(){


		 /*
		adSpawnPoints.Add(adSpawnpoint1);
		adSpawnPoints.Add(adSpawnpoint2);
		adSpawnPoints.Add(adSpawnpoint3);
		adSpawnPoints.Add(adSpawnpoint4);
		*/
	}
 
	void Update(){
		
		
		/*
		var randomSpawnPoint = adSpawnPoints[Random.Range(0, adSpawnPoints.Count)];

		if (Input.GetKey(KeyCode.Space)){
			Instantiate(adProducts, randomSpawnPoint, Quaternion.identity);
		}

		
		float x = Random.Range(minX, maxX);
		float y = Random.Range(minY, maxY);
		float z = Random.Range(minZ, maxZ);

		if (Input.GetKey(KeyCode.Space)){
			Instantiate(adProducts, new Vector3(x,y,z), Quaternion.identity);
		*/
	}
}
