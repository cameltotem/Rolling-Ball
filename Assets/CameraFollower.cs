using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {

	public GameObject PlayerBall;
	private Vector3 offset;

	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = PlayerBall.transform.position + offset;
	}
}


