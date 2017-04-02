using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		move ();
	}

	private void move ()
	{
		// 左矢印が押されたとき
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			LButtonDown ();
		}
		// 右矢印が押されたとき
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			RButtonDown ();
		}
		Debug.Log (transform.position.x);
	}

	public void LButtonDown ()
	{
		transform.Translate (-3, 0, 0);
	}

	public void RButtonDown ()
	{
		transform.Translate (3, 0, 0);
	}
}
