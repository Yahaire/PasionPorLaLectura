using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaEncuesta : MonoBehaviour {

	// Exclusivamente para desbloqueo del libro
	private DB db;

	// Objetos de interfaz a modificar
	public GameObject UIPregunta;
	public GameObject UIOpcion1;
	public GameObject UIOpcion2;
	public GameObject UIOpcion3;
	public GameObject UIOpcion4;

	// Preguntas y respuestas
	private string[,] preguntasYRespuestas;
	private int respuestasCorrectas;
	private int meta = 3; // Cuantas respuestas correctas para ganar
	private int respuestaCorrecta = 1;
	private string nombreLibro;
	private bool desbloqueado;

	// Use this for initialization
	void Start () {
		// Conexión con la base de datos
		//db = GameObject.FindGameObjectsWithTag("DBManager")[0].GetComponent<DB>();
		//reiniciarEncuesta ();
	}

	void reiniciarEncuesta () {
		int respuestasCorrectas = 0;

		if (!desbloqueado) {
			// Activar botones
			UIOpcion1.SetActive (true);
			UIOpcion2.SetActive (true);
			UIOpcion3.SetActive (true);
			UIOpcion4.SetActive (true);
		} else {
			UIPregunta.GetComponent<Text> ().text = "Felicidades! Desbloqueaste el libro " + nombreLibro + "!";
			UIOpcion1.SetActive (false);
			UIOpcion2.SetActive (false);
			UIOpcion3.SetActive (false);
			UIOpcion4.SetActive (false);
		}
	}
		

	public void iniciarEncuesta(string[,] preguntasYRespuestas, string nombreLibro, DB db) {
		this.preguntasYRespuestas = preguntasYRespuestas;
		this.nombreLibro = nombreLibro;
		this.reiniciarEncuesta ();
		this.db = db;
		desbloqueado = db.libroDesbloqueado (nombreLibro);

		cargarPregunta (0);
	}

	private void cargarPregunta(int numPregunta) {
		bool desbloqueado = db.libroDesbloqueado (nombreLibro);

		if (!desbloqueado && respuestasCorrectas < meta) {
			string pregunta = preguntasYRespuestas [numPregunta, 0];
			string respuestaC = preguntasYRespuestas [numPregunta, 1];
			string respuestaF1 = preguntasYRespuestas [numPregunta, 2];
			string respuestaF2 = preguntasYRespuestas [numPregunta, 3];
			string respuestaF3 = preguntasYRespuestas [numPregunta, 4];

			UIPregunta.GetComponent<Text> ().text = pregunta;
			UIOpcion1.GetComponentInChildren<Text> ().text = respuestaC;
			UIOpcion2.GetComponentInChildren<Text> ().text = respuestaF1;
			UIOpcion3.GetComponentInChildren<Text> ().text = respuestaF2;
			UIOpcion4.GetComponentInChildren<Text> ().text = respuestaF3;
		} else {
			// actualizar base de datos
			db.desbloquearLibro (nombreLibro);

			UIPregunta.GetComponent<Text> ().text = "Felicidades! Desbloqueaste el libro " + nombreLibro + "!";
			UIOpcion1.SetActive (false);
			UIOpcion2.SetActive (false);
			UIOpcion3.SetActive (false);
			UIOpcion4.SetActive (false);

			//mostrar imagen del libro
		}

	}

	public void revisarOpcion1 () {
		if (respuestaCorrecta == 1) {
			respuestasCorrectas++;
			cargarPregunta (respuestasCorrectas);
		} else {
			// la regaste
		}
	}

	public void revisarOpcion2 () {
		if (respuestaCorrecta == 2) {
			respuestasCorrectas++;
			cargarPregunta (respuestasCorrectas);
		} else {
			// la regaste
		}
	}

	public void revisarOpcion3 () {
		if (respuestaCorrecta == 3) {
			respuestasCorrectas++;
			cargarPregunta (respuestasCorrectas);
		} else {
			// la regaste
		}
	}

	public void revisarOpcion4 () {
		if (respuestaCorrecta == 4) {
			respuestasCorrectas++;
			cargarPregunta (respuestasCorrectas);
		} else {
			// la regaste
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
