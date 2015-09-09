using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;

public class ShowHighScore : MonoBehaviour {
	string highscoreURL = "http://felix.gege.se/displayscore1.php";
	public Text highscore;


	void Start () {
		StartCoroutine (showhighscore ());

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	IEnumerator showhighscore()
	{
		highscore.text = "Loading scores";

		WWW hs_get = new WWW (highscoreURL);
		yield return hs_get;

		if (hs_get.error != null) {

			print ("there was an error" + hs_get.error);
		} else {
			highscore.text = hs_get.text;
		}

	}
}
