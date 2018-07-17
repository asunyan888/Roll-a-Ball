using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public void Update()
    {
        // 獲得ポイントを表示
        int point = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = point.ToString();

        if (point == 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}