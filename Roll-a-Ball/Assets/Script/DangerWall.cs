using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour {
    public GameObject loseLabelObject;

	void OnCollisionEnter(Collision hit)
	{
        if (hit.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("LoseScene");
            
        }
		
	}
}
