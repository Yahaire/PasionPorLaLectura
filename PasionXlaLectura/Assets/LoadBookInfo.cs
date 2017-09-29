using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadBookInfo : MonoBehaviour {

    private DB db;

    public GameObject gbjAutor;
    public GameObject gbjGenero;
    public GameObject gbjLugarPub;
    public GameObject gbjFecha;
    public GameObject gbjSinopsis;
    public GameObject gbjTitulo;
    // Use this for initialization
    void Start () {

        db = GameObject.FindGameObjectWithTag("DBManager").GetComponent<DB>();


    }
	
	// Update is called once per frame
	void Update () {


		
	}

    public void Click(string s)
    {
        string[] result = db.informacionLibro(s);

        Debug.Log(result[0]);
        Debug.Log(result[1]);
        Debug.Log(result[2]);
        Debug.Log(result[3]);
        Debug.Log(result[4]);

        /*public GameObject gbjAutor = GameObject.Find("Autor");
        public GameObject gbjGenero = GameObject.Find("Genero");
        public GameObject gbjLugarPub = GameObject.Find("LugarPub");
        public GameObject gbjFecha = GameObject.Find("Fecha");
        public GameObject gbjSinopsis = GameObject.Find("Sinopsis");*/

        gbjAutor.GetComponent<Text>().text = result[0];
        gbjGenero.GetComponent<Text>().text = result[1];
        gbjLugarPub.GetComponent<Text>().text = result[2];
        gbjFecha.GetComponent<Text>().text = result[3];
        gbjSinopsis.GetComponent<Text>().text = result[4];

        gbjTitulo.GetComponent<Text>().text = s;


    }
}
