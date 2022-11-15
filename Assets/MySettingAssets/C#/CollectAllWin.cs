using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectAllWin : MonoBehaviour {
	void Start () {

	}

	void Update () {
		
		if (PlayerStat.candy == 0) {
			SceneManager.LoadScene("WinScene");
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}
