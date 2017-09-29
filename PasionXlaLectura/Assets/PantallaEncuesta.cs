using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaEncuesta : MonoBehaviour {

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

	// Use this for initialization
	void Start () {
		reiniciarEncuesta ();
	}

	void reiniciarEncuesta () {
		int respuestasCorrectas = 0;
	}

	public void algo() {
	}

	public void iniciarEncuesta(string[,] preguntasYRespuestas) {
		this.preguntasYRespuestas = preguntasYRespuestas;
		this.reiniciarEncuesta ();

		while (respuestasCorrectas < meta) {
			cargarPregunta (respuestasCorrectas);
		}
	}

	private void cargarPregunta(int numPregunta) {
		string pregunta = preguntasYRespuestas [numPregunta, 0];
		string respuestaC = preguntasYRespuestas [numPregunta, 1];
		string respuestaF1 = preguntasYRespuestas [numPregunta, 2];
		string respuestaF2 = preguntasYRespuestas [numPregunta, 3];
		string respuestaF3 = preguntasYRespuestas [numPregunta, 4];

		UIPregunta.GetComponent<Text> ().text = pregunta;
		UIOpcion1.GetComponent<Text> ().text = respuestaC;
		UIOpcion2.GetComponent<Text> ().text = respuestaF1;
		UIOpcion3.GetComponent<Text> ().text = respuestaF2;
		UIOpcion4.GetComponent<Text> ().text = respuestaF3;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
