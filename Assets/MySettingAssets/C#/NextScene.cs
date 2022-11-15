using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {
	public static bool Over = false;// check status when game is over
	public static bool Begin = true;// check status when game is begin
	void Start () {

	}
	
	// Update is called once per frame

	private void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Over = true; //when get attacked gameover is true
			Begin = false; //when gameover is over 
			SceneManager.LoadScene("GameOver");
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}

