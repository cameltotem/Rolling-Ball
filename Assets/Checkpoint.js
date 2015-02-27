#pragma strict

var SpawnPoint : Transform;
var CheckPoint : GameObject;

var Audio : AudioSource;

function OnTriggerEnter(col : Collider)
{
if(col.tag =="Player")
{
   SpawnPoint.position = Vector3(transform.position.x,transform.position.y,transform.position.z);
   Audio.Play();
   Destroy(CheckPoint);
   }
   
   
   }
   
   function Update()
   {
   transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
   //transform.RotateAround(Vector3.zero, Vector3.up, 200 * Time.deltaTime);
   
   
   }