using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    public void Update()
    {
        // アイテムの残り個数をカウント
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if (count == 0)
        {
            winnerLabelObject.SetActive(true);
        }
    }
}