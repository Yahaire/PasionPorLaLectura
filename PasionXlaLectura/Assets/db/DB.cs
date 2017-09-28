using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;

public class DB : MonoBehaviour {

    private SimpleSQLManager db;

    // Use this for initialization
    void Start() {
        db = GetComponent<SimpleSQLManager>();

        SimpleDataTable dt = db.QueryGeneric("SELECT * FROM Usuario");
        Debug.Log(dt.rows[0]["nombre"].ToString());
	}
	
    public string testDB()
    {
        return "not checking yet";
    }

    public string getIdLibro(string nombreLibro)
    {
        SimpleDataTable dt = db.QueryGeneric("SELECT idLibro FROM Libros WHERE nombreLibro = '" + nombreLibro + "'");
        return dt.rows[0]["idLibro"].ToString();
    }

    public int getCountLibrosLeidos()
    {
        SimpleDataTable dt = db.QueryGeneric(
                "SELECT COUNT(*) AS cantidad FROM Libros WHERE desbloqueado = 1");
        return (int)dt.rows[0]["cantidad"];
    }

    public string[] getPreguntasYRespuestas(string nombreLibro)
    {
        string[] result = new string[4];

        SimpleDataTable dt = db.QueryGeneric(
                "SELECT pregunta, respuesta, respuesta_f1, respuesta_f2" +
                "FROM Preguntas pre, Libros lib " +
                "WHERE nombreLibro = '" + nombreLibro + "'" +
                "   AND lib.idLibro = pre.idLibro");
        result[0] = dt.rows[0]["pregunta"].ToString();
        result[1] = dt.rows[0]["respuesta"].ToString();
        result[2] = dt.rows[0]["respuesta_f1"].ToString();
        result[3] = dt.rows[0]["respuesta_f2"].ToString();

        return result;
    }
}
