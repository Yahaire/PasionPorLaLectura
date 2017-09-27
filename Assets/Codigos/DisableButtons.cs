using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class DisableButtons : MonoBehaviour {

	public GameObject button17;
	public GameObject button23;
	public GameObject button30;
	public GameObject button51;
	public GameObject button86;

	public static SaveLoad control;
	//public static float experience = SaveLoad.experience;
	public static int[] libros = SaveLoad.libros;

	void Start ()
	{
		Debug.Log ("LOAD START");
		Load ();
		Debug.Log ("LOAD END");
		//float experience = SaveLoad.experience;
		//button.GetComponent<Button>().interactable = false;
	}
	
	public void Load ()
	{
		if (File.Exists (Application.persistentDataPath + "/saveFile.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/saveFile.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);

			file.Close ();

			//experience = data.experience;

			/*
			if (experience >= 100) 
			{
				Debug.Log ("LOAD COMPLETE");
				button.GetComponent<Button>().interactable = true;
			}
			*/
			//Drácula
			if (libros[0] == 1) 
				button17.GetComponent<Button>().interactable = true;
			//Doctor
			if (libros[1] == 1) 
				button23.GetComponent<Button>().interactable = true;
			//Perfume
			if (libros[2] == 1) 
				button30.GetComponent<Button>().interactable = true;
			//Metamorfosis
			if (libros[3] == 1) 
				button51.GetComponent<Button>().interactable = true;
			//Peter
			if (libros[4] == 1) 
				button86.GetComponent<Button>().interactable = true;
		}
	}
}