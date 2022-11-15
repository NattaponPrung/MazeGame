using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        PlayerStat.candy = 5; //resume game with 5 stack
    }

    public void Retry()
    {
        if (NextScene.Over == true)
        {
            NextScene.Begin = true;
            NextScene.Over = false;

            SceneManager.LoadScene("GameScene");//
        }
    }

    public void Playgame()
    {
        if (NextScene.Over == false) {
            SceneManager.LoadScene("GameScene");
        }
    }
    public void LoadMenu()
    {
        NextScene.Begin = true;
        NextScene.Over = false;
        SceneManager.LoadScene("MenuScene");
    }
    public void Quitgame()
    {
        Debug.Log("QUIT!!");
        Application.Quit();
    }
}
