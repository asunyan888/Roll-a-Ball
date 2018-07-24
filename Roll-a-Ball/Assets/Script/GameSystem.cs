using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameSystem : MonoBehaviour {

    public void GameStart(){
        SceneManager.LoadScene("Stage01");
    }

    public void GameEnd(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

        #elif UNITY_WEBPLAYER
         Application.OpenURL("http://www.yahoo.co.jp/");
    #else
        Application.Quit();
    #endif 
    }

    public void GoHome(){
        SceneManager.LoadScene("Title");
    }
}
