using UnityEngine;
using System.Collections;

public class StartLevel : MonoBehaviour {


	// Update is called once per frame
	public void ChangeToScene (int sceneToChangeTo) {

		Application.LoadLevel(sceneToChangeTo);
		Time.timeScale = 1;

	
	}
}
