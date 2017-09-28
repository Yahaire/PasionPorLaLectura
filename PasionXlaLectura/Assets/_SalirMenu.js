 #pragma strict
 //public var GameObject Canvas;

 var menu : GameObject;
 var sombrero : GameObject;
 var isShowing = false;

 function Start () 
{
	menu.SetActive (false);
}

 function SalirMenu()
 {
 	//sombrero.SetActive (true);
	menu.SetActive (false);
 }