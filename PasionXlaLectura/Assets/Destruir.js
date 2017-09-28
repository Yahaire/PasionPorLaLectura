#pragma strict
import UnityEngine.UI;

var menu : GameObject;
var botonatras : GameObject;
var texto: Text;

//var isShowing : Boolean;
//var isShowing = false;


function Start () 
{
	//menu.SetActive (false);
	//DrSimi = GetComponent.<UnityEngine.UI.Text>();
	//DrSimi.text = "Hello im some text";

	//Debug.Log("Arriba");
	//Debug.Log(DrSimi);
	//Debug.Log("Abajo");
}

 function Update ()
 {
     if ( Input.GetMouseButtonDown(0))
     {
     	 Debug.Log ("Input");
         var hit : RaycastHit;
         var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
         //var rayTouch : Ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
         
         if (Physics.Raycast (ray, hit, 100.0))
         {  
         	Debug.Log ("Raycast");
         	//isShowing = !isShowing;
			//Debug.Log("Lo va a encontrar");
			menu.SetActive (true);
			if (GameObject.Find("Dracula_Murcielago") != null && hit.collider.name == "Dracula_Murcielago")
			{
				texto.text = "¿Por qué ver por separadas esta vida y la siguiente si una proviene de la anterior? ... Habla del anhelo, de un alma que clama por otra.";
				GameObject.Find("Dracula_Murcielago").SetActive (false);
				Destroy(GameObject.Find("Dracula_Murcielago"));
			}

			if (GameObject.Find("Sombrero") != null && hit.collider.name == "Sombrero")
			{
				texto.text = "Las dos provincias del bien y del mal que componen la doble naturaleza del hombre.";
				GameObject.Find("Sombrero").SetActive (false);
				Destroy(GameObject.Find("Sombrero"));
			}

			if (GameObject.Find("perfumeUV") != null && hit.collider.name == "perfumeUV")
			{
				texto.text = "En cierto modo, la cárcel es a la humanidad lo que la quintaesencia al perfume: el concentrado absoluto.";
				GameObject.Find("perfumeUV").SetActive (false);
				Destroy(GameObject.Find("perfumeUV"));
			}

			if (GameObject.Find("Metamorfosis_Cucaracha") != null && hit.collider.name == "Metamorfosis_Cucaracha")
			{
				texto.text = "A pesar de su triste y repulsivo aspecto, era un miembro de la familia al que no se podía tratar como a un enemigo.";
				GameObject.Find("Metamorfosis_Cucaracha").SetActive (false);
				Destroy(GameObject.Find("Metamorfosis_Cucaracha"));
			}

			if (GameObject.Find("PedroParamo_Sombrero") != null && hit.collider.name == "PedroParamo_Sombrero")
			{
				texto.text = "Cada suspiro es como un sorbo de vida del que uno se deshace.";
				GameObject.Find("PedroParamo_Sombrero").SetActive (false);
				Destroy(GameObject.Find("PedroParamo_Sombrero"));
			}

			if (GameObject.Find("rose") != null && hit.collider.name == "rose")
			{
				texto.text = "Frase del principito.";
				GameObject.Find("rose").SetActive (false);
				Destroy(GameObject.Find("rose"));
			}

			if (GameObject.Find("skull") != null && hit.collider.name == "skull")
			{
				texto.text = "Luis Me la pela";
				GameObject.Find("skull").SetActive (false);
				Destroy(GameObject.Find("skull"));
			}

			//Debug.Log("Lo encontró?");
            //Destroy(GameObject.Find("targetArea"));
            //Destroy(GameObject.Find("Sombrero"));
         }
     }
 }

