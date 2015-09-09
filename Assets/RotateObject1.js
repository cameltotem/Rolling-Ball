#pragma strict

function Start () {

}

function Update () {

transform.Rotate(new Vector3(0,2,0) * Time.deltaTime);
}