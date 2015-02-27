using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float force;
	// Bollens kraft i motion








	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");



		Vector3 ballMovement = new Vector3(moveHorizontal,0.0f,moveVertical);

		rigidbody.AddForce(ballMovement * force);

		//InvokeRepeating("Jumpe",2,0.3f);


		}



}
