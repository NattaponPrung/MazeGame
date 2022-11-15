using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CandyEvent : MonoBehaviour {
	public AudioClip item_sound;
	public int candy_item; 

	
	public void OnTriggerEnter(Collider other)
	{
		AudioSource.PlayClipAtPoint(item_sound, transform.position, 1f);
		GameObject obj1 = GameObject.Find("Text");
		Text t1 = obj1.GetComponent<Text>();
		Text t2 = obj1.GetComponent<Text>();
		if (NextScene.Over == false) 
		{ 
			string display_text2 = string.Format("Diamond:5");
			t2.text = display_text2;
			NextScene.Over = false;//retry

			if (NextScene.Begin == true)
			{
				PlayerStat.candy += candy_item;
				string display_text = string.Format("Diamond:{0}", PlayerStat.candy);
				t1.text = display_text;
				Destroy(gameObject);
				NextScene.Begin = true;
				if (PlayerStat.candy == 0)
				{
					SceneManager.LoadScene("WinScene");
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}		
	}
}

