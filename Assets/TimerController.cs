using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System;

public class TimerController : MonoBehaviour {
	
	
	string registerURL = "http://felix.gege.se/registertime.php";
	string highscoreURL = "http://felix.gege.se/displayscore1.php";
	string username ="";
	string problem = "";
	string score ="";
	float timer;
	//public Text scoreText;

	
	
	void Start()
	{
	


	}




	void update()
	{
		timer += Time.deltaTime;

	}
	void OnGUI()
	{
		GUI.Window(0, new Rect(630,420,375,150),
		           RegisterWindow,"Register new highscore");



	}
	
	
	void RegisterWindow(int windowID)
	{
		GUI.Label(new Rect(140,40,130,100), "---Nickname---");
		username = GUI.TextField( new Rect(25,60,325,30), username);
		
		
		if(GUI.Button( new Rect(130,95,110,50), "Save time"))
			StartCoroutine(handleRegister(username));
		
		GUI.Label(new Rect(55,222,250,100), problem);
	}





	IEnumerator handleRegister(string username) 	
	{
		if (string.IsNullOrEmpty(username)) {
			return string.IsNullOrEmpty(username);

		
		

		}
		System.TimeSpan t = System.TimeSpan.FromSeconds (Time.time);
		string score = string.Format ("{0:D2}s", t.Seconds);

	

		string register_URL = registerURL + "?username=" + username + "&score=" + score;
		WWW registerReader = new WWW (register_URL);
		yield return registerReader;


		if(registerReader.error != null)
		{
			problem = "Could not locate page";

		}
		else { 
			if(registerReader.text == "registered" )
			{
				problem = "registered";
			} else {
				problem = "New highscore saved!";

				// Close highscore menu when saved
				Destroy (gameObject);

			}
		}
		

	}
	

	
	
	
	
}