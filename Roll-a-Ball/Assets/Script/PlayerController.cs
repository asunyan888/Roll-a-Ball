using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public int count;
    public float speed = 10;
    public UnityEngine.UI.Text scoreLabel;

	private void Start()
	{
        count = 0;
        SetCountText();
	}
	void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // rigidbodyのx軸（横）とz軸（奥）に力を加える
        rigidbody.AddForce(x*speed, 0, z*speed);
    }
    private void OnTriggerEnter(Collider hit)
    {
        // 接触対象がItemであれば
        if (hit.CompareTag("Item"))
        {
            count = count+1;
            SetCountText();
        }
    }
    private void SetCountText(){
        scoreLabel.text = count.ToString();
    }
}