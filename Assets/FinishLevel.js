#pragma strict


var Audio : AudioSource;
var FinishLine: GameObject;
var FinishButton: GameObject;
var FinishText: GameObject;
var FinishImage: GameObject;
var FinishTryAgain : GameObject;
var FinishSaveHighScore: GameObject;
var FinishShowHighScore: GameObject;
var FinishShowHighScoreText: GameObject;
var BackgroundPanel : GameObject;
//var timer:float;


function OnTriggerEnter(col : Collider)
{
if(col.tag == "Player")

{

FinishButton.SetActive(true);
FinishText.SetActive(true);
FinishImage.SetActive(true);
FinishTryAgain.SetActive(true);
FinishSaveHighScore.SetActive(true);
FinishShowHighScore.SetActive(true);
FinishShowHighScoreText.SetActive(true);
BackgroundPanel.SetActive(true);
Audio.Play();
Destroy(FinishLine);
Time.timeScale = 0.000001;
}
}

function Update () {

transform.Rotate(new Vector3(15,40,20) * Time.deltaTime);



//timer += Time.deltaTime;
   // tiden som går.
}

   // Okej timern fungerar, bara koppla till sql :D