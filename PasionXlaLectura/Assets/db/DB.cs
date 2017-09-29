using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;

public class DB : MonoBehaviour {

    private SimpleSQLManager db;

    // Use this for initialization
    void Start() {
        db = GetComponent<SimpleSQLManager>();
        /* a simple test with an old table
        SimpleDataTable dt = db.QueryGeneric("SELECT * FROM Usuario");
        Debug.Log(dt.rows[0]["nombre"].ToString());
        */
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

    public bool libroDesbloqueado(string nombreLibro)
    {
        SimpleDataTable dt = db.QueryGeneric(
                "SELECT desbloqueado " +
                "FROM Libros " +
                "WHERE nombreLibro = '" + nombreLibro + "'");

        return (bool)dt.rows[0]["desbloqueado"];
    }

    public bool desbloquearLibro(string nombreLibro)
    {
        SimpleDataTable dt = db.QueryGeneric(
                "UPDATE Libros " +
                "SET desbloqueado = 1 " +
                "WHERE nombreLibro = '" + nombreLibro + "'");
        // si se puede hacer un chequeo aquí, debería hacerse
        return true;
    }

    public int cantidadLibrosLeidos()
    {
        SimpleDataTable dt = db.QueryGeneric(
                "SELECT COUNT(*) AS cantidad FROM Libros WHERE desbloqueado = 1");
        return (int)dt.rows[0]["cantidad"];
    }

    public string[,] getPreguntasYRespuestas(string nombreLibro)
    {
        string[,] result = new string[5,4];

        SimpleDataTable dt = db.QueryGeneric(
                "SELECT pregunta, respuesta, respuesta_f1, respuesta_f2 " +
                "FROM Preguntas pre, Libros lib " +
                "WHERE nombreLibro = '" + nombreLibro + "' " +
                "   AND lib.idLibro = pre.idLibro");
        for (int i = 0; i < 5; i++)
        {
            result[i,0] = dt.rows[0]["pregunta"].ToString();
            result[i,1] = dt.rows[0]["respuesta"].ToString();
            result[i,2] = dt.rows[0]["respuesta_f1"].ToString();
            result[i,3] = dt.rows[0]["respuesta_f2"].ToString();
        }

        return result;
    }

	public string[] informacionLibro(string nombreLibro)
	{
		string sQuery = "SELECT autor, genero, lugarDePublicacion, fecha, sinopsis FROM Libros WHERE nombreLibro = '" + nombreLibro + "'";
		SimpleDataTable dt = db.QueryGeneric(sQuery);

		string sAutor = dt.rows[0]["autor"].ToString();
		string sGenero = dt.rows[0]["genero"].ToString();
		string sLugarP = dt.rows[0]["lugarDePublicacion"].ToString();
		string sFecha = dt.rows[0]["fecha"].ToString();
		string sSinopsis = dt.rows[0]["sinopsis"].ToString();

		string[] sResult = new string[5];

		sResult[0] = sAutor;
		sResult[1] = sGenero;
		sResult[2] = sLugarP;
		sResult[3] = sFecha;
		sResult[4] = sSinopsis;

		return sResult;

	}

    
}
