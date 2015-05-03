using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {
	
	
	string registerURL = "http://felix.gege.se/registertime.php";
	string highscoreURL = "http://felix.gege.se/displayscore1.php";
	string username ="";
	string problem = "";
	public Text scoreText;
	
	
	void Start()
	{
		StartCoroutine(GetScores());
	}
	
	void OnGUI()
	{
		GUI.Window(0, new Rect(Screen.width / 4, Screen.height / 4, Screen.width / 4, Screen.height / 2 - 70),
		           RegisterWindow,"Login");
	}
	
	
	
	void RegisterWindow(int windowID)
	{
		GUI.Label(new Rect(140,40,130,100), "---Nickname---");
		username = GUI.TextField( new Rect(25,60,375,30), username);
		
		
		if(GUI.Button( new Rect(130,120,175,50), "Save time"))
			StartCoroutine(handleRegister(username));
		
		GUI.Label(new Rect(55,222,250,100), problem);
	}
	
	
	
	IEnumerator handleRegister(string username) 	
	{
		System.TimeSpan t = System.TimeSpan.FromSeconds (Time.time);
		string score = string.Format ("{0:D2}m:{1:D2}s", t.Minutes, t.Seconds);
		
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
				problem = "Did not registered";
			}
		}
		
		Debug.Log(t);
	}
	
	IEnumerator GetScores()
	{
		scoreText.text ="Loading scores";
		
		WWW hs_get = new WWW(highscoreURL);
		yield return hs_get;
		
		if (hs_get.error != null)
		{
			print("There was an error getting the high score: " + hs_get.error);
		}
		else
		{
			scoreText.text = hs_get.text; // this is a GUIText that will display the scores in game.
		}
	}
	
	
	
	
}