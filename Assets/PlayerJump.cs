using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {
	public float force;
	private bool isFalling =false;
	public AudioSource jump;
	public float timer = 0.0f;
	public Text time;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float Jump = Input.GetAxis("Jump");
		Vector3 ballMovement1 = new Vector3(0.0f, Jump, 0.0f);
		timer += Time.deltaTime;


		if(timer <= 0)
		{
			timer = 0;
		}
		
		if(Input.GetKeyDown(KeyCode.Space) && isFalling == false)
		{
			GetComponent<Rigidbody>().AddForce(ballMovement1 * force );
			jump.Play();

		}
		isFalling = true;
	}


	public void OnGUI()
	{
		GUI.Box(new Rect(700,100,100,40), "" + timer.ToString("0.00"));
	

	}
	void OnCollisionStay ()
	{
		isFalling = false;
	}
	
}﻿