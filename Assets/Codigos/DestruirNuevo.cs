﻿using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DestruirNuevo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.tag == "Sombrero") {
					Debug.Log ("AUTODESTRUCCION C#");
					//GameObject.Find("Sombrero").SetActive (false);
					Destroy (GameObject.Find ("Sombrero"));
				}
			*/
			}

	void OnMouseDown()
	{
		Debug.Log ("AUTODESTRUCCION C# FAIL");

		/*GameObject thePlayer = GameObject.Find("SaveLoad");
		SaveLoad experience = thePlayer.GetComponent<SaveLoad> ();
		experience.experience += 1;
		*/

		//float experience = SaveLoad.experience;
		int[] libros = SaveLoad.libros;

		//experience += 1;
		/*
		for (int i = 0; i < libros.Length; i++)
		{
			Debug.Log ("Posición " + i);
			if (libros [i] == 0) 
			{
				libros [i] = 1;
			}
			Debug.Log ("Guardado como " + libros[i]);
		}
		*/

		if(this.gameObject.name == "Murcielago")
			libros [0] = 1;
		if(this.gameObject.name == "Sombrero")
			libros [1] = 1;
		if(this.gameObject.name == "Perfume")
			libros [2] = 1;
		if(this.gameObject.name == "Cucaracha")
			libros [3] = 1;
		if(this.gameObject.name == "Pedrito")
			libros [4] = 1;
		

		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create(Application.persistentDataPath + "/saveFile.dat");

		PlayerData data = new PlayerData ();
		//data.experience = experience;
		data.libros = libros;

		bf.Serialize (file, data);
		file.Close ();

		Debug.Log ("AUTODESTRUCCION C#");
	} 
}
