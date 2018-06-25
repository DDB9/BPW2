using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public GameObject menuMain;
	public GameObject menuInstructions;

	public void exitGame(){ // Quits the game.
		Application.Quit();
	}

	public void startGame(){ // Starts the game.
		SceneManager.LoadScene(1);
		gameManager.adActive = false;
	}

	public void mainMenu(){
		SceneManager.LoadScene(0);
		gameManager.adActive = false;
	}
	
	public void toInstructions(){
		menuMain.SetActive(false);
		menuInstructions.SetActive(true);
	}
	
	public void toMainMenu(){
		menuMain.SetActive(true);
		menuInstructions.SetActive(false);
	}
}
