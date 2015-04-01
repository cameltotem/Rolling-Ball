using UnityEngine;
using System.Collections;

public class LoginMenu : MonoBehaviour {
	
	string loginURL ="http://127.0.0.1:8080/login.php";
	string registerURL = "http://127.0.0.1:8080/register.php";
	// byt till vanlig port, ändra också till localhost i PHP.
	string password ="";
	string problem = "";
	string username ="";
	
	
	
	void OnGUI()
	{
		GUI.Window(0, new Rect(Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2 - 70),
		           LoginWindow,"Login");
	}
	
	
	void LoginWindow(int windowID)
	{
		GUI.Label(new Rect(140,40,130,100), "---Username----");
		username = GUI.TextField( new Rect(25,60,375,30), username);
		GUI.Label(new Rect(140, 92, 130, 100), "----Password-----");
		password = GUI.TextField( new Rect(25,115,375,30), password);
		
		if(GUI.Button( new Rect(25,160,175,50), "Login"))
			StartCoroutine(handleLogin(username,password));
		if(GUI.Button( new Rect(225,160,175,50), "Register"))
			StartCoroutine(handleRegister(username,password));
		
		GUI.Label(new Rect(55,222,250,100), problem);
	}
	
	IEnumerator handleLogin (string username, string password) 
	{
		problem = "Checking username and password...";
		string login_URL = loginURL + "?username=" + username + "?password=" + password;
		WWW loginReader = new WWW (login_URL);
		yield return loginReader;
		
		if(loginReader.error != null)
		{
			problem = "Could not locate page";
		}
		else { 
			if(loginReader.text == "right" )
			{
				problem = "logged in";
			} else {
				problem = "invalid user/pass";
			}
		}
	}
	
	
	
	IEnumerator handleRegister(string username, string password) 
	{
		
		string register_URL = registerURL + "?username=" + username + "&password=" + password;
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
	}
	
	
	
	
	
	
	
}
