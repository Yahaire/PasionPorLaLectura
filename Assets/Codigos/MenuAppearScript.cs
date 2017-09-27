using UnityEngine;
using System.Collections;

public class MenuAppearScript : MonoBehaviour {

	public GameObject Canvas; // Assign in inspector
	private bool isShowing;

	void Update() {
		if (Input.GetKeyDown("escape")) {
			isShowing = !isShowing;
			Canvas.SetActive(isShowing);
		}
	}
}