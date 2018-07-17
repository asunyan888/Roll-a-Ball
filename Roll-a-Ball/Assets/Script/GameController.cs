using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    public void Update()
    {
        // 獲得ポイントを表示
        int point = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = point.ToString();

        if (point == 0)
        {
            winnerLabelObject.SetActive(true);
        }
    }
}