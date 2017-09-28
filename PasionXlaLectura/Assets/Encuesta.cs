using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encuesta : MonoBehaviour {
    
    private DB db;
    [HideInInspector]
    public GameObject menuEncuesta;
    [HideInInspector]
    public string nombreLibro;

	// Use this for initialization
	void Start () {
        // Conexión con la base de datos
        db = GameObject.FindGameObjectsWithTag("DBManager")[0].GetComponent<DB>();

        // Conexión con la pantalla de encuestas
        //menuEncuesta = GameObject.FindGameObjectsWithTag("MenuEncuesta")[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                string objectName = this.gameObject.name;
                Debug.Log("Su libro es" + nombreLibro);
                Debug.Log(db.testDB() + "...eso dice la db");
                Debug.Log("El ID de " + nombreLibro + " es " + db.getIdLibro(nombreLibro));

                menuEncuesta.SetActive(true);
            } else { Debug.Log("Nothing was hit"); }
            
        }
    }
}
