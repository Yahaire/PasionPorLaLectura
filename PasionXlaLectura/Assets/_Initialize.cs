using UnityEngine;
using System.Collections;

public class Initialize : MonoBehaviour {

	public GameObject menu;
	private bool isShowing;

	// Use this for initialization
	void Start () 
	{
		menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("escape"))
		{
			isShowing = !isShowing;
			menu.SetActive (isShowing);
		}
	}
}
