using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscenes: MonoBehaviour{

	public void loadExploar(){
		SceneManager.LoadScene("exploraPPLL");
	}

	public void loadMenu(){
		SceneManager.LoadScene("menuPPLL");
	}
}