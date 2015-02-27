using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public Transform SpawnPoint;
	public GameObject Player;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Player")
		{

			Player.transform.position = SpawnPoint.position;



	}
	}


	// Update is called once per frame
	void Update () {

	}
}
