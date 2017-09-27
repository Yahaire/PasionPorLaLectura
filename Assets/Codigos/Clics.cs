using UnityEngine;
using System.Collections;

public class Clics : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){ // if left button pressed...
			Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				if(hit.collider.tag == "areaTarget")
				{
					//GameObject obj=GameObject.FindGameObjectWithTag("clickableCube");
					//obj.GetComponent<Animation>().Play("cube");
					Destroy(GameObject.Find("targetArea"));
				}
			}
		}
	}
}
