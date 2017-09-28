using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;

public class TouchableObject : MonoBehaviour {

	RaycastHit hit;
	Ray ray;
	Ray rayTouch;
	public Canvas Canvas;


	// Use this for initialization
	void Start () {
		Debug.Log("Si funciona");
		Canvas.enabled = false;
		//model_1 = transform.FindChild ("SalirButton").gameObject;
		//model_1.SetActive(false);
	}

	// Update is called once per frame
	void Update () 
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		//rayTouch = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);

		if(Physics.Raycast(ray, out hit))
		{
			//Debug.Log(" you clicked on " + hit.collider.gameObject.name);

			if(hit.collider.gameObject.name == "targetArea")
			{
				Debug.Log(" you clicked on ");
				Canvas.enabled = true;
				//CanvasObject.GetComponent<Canvas>().enabled = false;
				//Destroy (GameObject.Find ("targetArea"));
			}
		}

		if(Physics.Raycast(rayTouch, out hit))
		{
			//Debug.Log(" you clicked on " + hit.collider.gameObject.name);

			if(hit.collider.gameObject.name == "targetArea")
			{
				Debug.Log(" you clicked on ");
				Canvas.enabled = true;
				//CanvasObject.GetComponent<Canvas>().enabled = false;
				//Destroy (GameObject.Find ("targetArea"));
			}
		}

		if(Input.GetKeyDown (KeyCode.Escape))
		{
			/*if(Canvas.enabled == true)
			{
				Canvas.enabled = false;
			} 
			else
			{
				Canvas.enabled = true;
			}*/
		}
	}
}
	