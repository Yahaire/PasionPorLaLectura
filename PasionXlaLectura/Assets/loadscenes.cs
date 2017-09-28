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

	public void Facebook(){
		Application.OpenURL ("https://www.facebook.com/pasionxlecturamty");
	}

	public void Pagina(){
		Application.OpenURL ("http://www.pasionporlalectura.itesm.mx");
	}

	public void Twitter(){
		Application.OpenURL ("https://twitter.com/PasionxLectura");
	}
}