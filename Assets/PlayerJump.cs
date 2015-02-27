using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {
	public float force;
	private bool isFalling =false;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float Jump = Input.GetAxis("Jump");
		Vector3 ballMovement1 = new Vector3(0.0f, Jump, 0.0f);
		
		if(Input.GetKeyDown(KeyCode.Space) && isFalling == false)
		{
			rigidbody.AddForce(ballMovement1 * force );
		}
		isFalling = true;
	}
	
	void OnCollisionStay ()
	{
		isFalling = false;
	}
	
}﻿