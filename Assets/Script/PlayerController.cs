using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	//speedを制御する
	public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //入力をxとzに代入
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //rigidbodyのx軸（横）とz軸（奥）に力を加える

        rb.AddForce(movement * speed);
    }
}
