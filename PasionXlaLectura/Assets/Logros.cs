using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logros : MonoBehaviour {

    private DB db;

    // Use this for initialization
    void Start () {
        // Conexión con la base de datos
        db = GameObject.FindGameObjectsWithTag("DBManager")[0].GetComponent<DB>();



        GetComponent<Text>().text = calcularPorcentaje(0.05f).ToString() + "%";
    }
	

    private float calcularPorcentaje(float valorLibro)
    {
        return db.cantidadLibrosLeidos() * valorLibro * 100;
    }
	
        
    // Update is called once per frame
	void Update () {
		
	}
}
