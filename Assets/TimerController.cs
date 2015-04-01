using UnityEngine;
using System.Collections;

public class TimerController : MonoBehaviour {

	//string loginURL ="http://127.0.0.1:8080/login.php";
	string registerURL = "http://127.0.0.1:8080/time.php";

	string name ="";
	string score ="";
	string problem = "";

	void LoginWindow(int windowID)
	{
		GUI.Label(new Rect(140,40,130,100), "---Username----");
		name = GUI.TextField( new Rect(25,60,375,30), name);
		GUI.Label(new Rect(140, 92, 130, 100), "----Password-----");
		score = GUI.TextField( new Rect(25,115,375,30), score);
		

		if(GUI.Button( new Rect(225,160,175,50), "Register"))
			//StartCoroutine(handleRegister(name,score));
		
		GUI.Label(new Rect(55,222,250,100), problem);
	}

	IEnumerator handleRegister(string name,int score)
	{
		string register_URL = registerURL + "?name=" + name + "&score=" + score;
		WWW registerReader = new WWW (register_URL);
		yield return registerReader;
	}
}
