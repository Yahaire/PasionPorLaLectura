using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour {

	public static SaveLoad control;

	public static int[] libros = new int[] {0,0,0,0,0,0};
	//public static float experience = 99;

	void Awake ()
	{
		if (control == null)
		{
			DontDestroyOnLoad (gameObject);
			control = this;
		} 
		else if (control != this)
		{
			Destroy (gameObject);
		}
	}

	void Start ()
	{
		Load ();
	}


	void OnGUI()
	{
		//GUI.Label (new Rect (10, 10, 100, 30), "Experience: " + experience);
		/*
		if (GUI.Button (new Rect (10, 140, 100, 30), "Dr. SIMI"))
		{
			libros[1] = 1;
		}
		if (GUI.Button (new Rect (10, 180, 100, 30), "SAVE"))
		{
			Save ();
		}

		if (GUI.Button (new Rect (10, 220, 100, 30), "+10"))
		{
			experience += 10;
		}
		*/

	}


	void Update ()
	{
	
	}

	public void Save ()
	{
		//C:\Users\adria_000\AppData\LocalLow
		//Local/Internal storage/Android/data/com.LaWeafome.WeonCuliao1/files
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create(Application.persistentDataPath + "/saveFile.dat");

		PlayerData data = new PlayerData ();
		//data.experience = experience;
		data.libros = libros;

		bf.Serialize (file, data);
		file.Close ();
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
			libros = data.libros;
		}
	}

	public void CheckFile()
	{
		if (File.Exists (Application.persistentDataPath + "/saveFile.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/saveFile.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);

			file.Close ();

			//experience = data.experience;
			libros = data.libros;
		}
	}

}

[Serializable]
class PlayerData
{
	//public float experience;
	public int[] libros;
}
