using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscenes: MonoBehaviour{
	
	//Back to menu 
	public void loadMenu(){
		SceneManager.LoadScene("menuPPLL");
	}

	public void loadExploar(){
		SceneManager.LoadScene("exploraPPLL");
	}

	public void load100_Libros(){
		SceneManager.LoadScene("100_LibrosPPLL");
	}

	public void loadLogros(){
		SceneManager.LoadScene("logrosPPLL");
	}

	public void loadPPLL(){
		SceneManager.LoadScene("PPLL");
	}
}