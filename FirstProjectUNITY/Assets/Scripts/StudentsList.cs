using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;



public class StudentsList : MonoBehaviour
{
    /*Declaracion de variables y constante para limpiar*/
    public Text NombreColumna;
    public Text ApellidoColumna;
    public Text GmailColumna;
    public Text NotaColumna;
    public Text IdentificacionColumna;
    public Text EdadColumna;

    private const string V = "";

    public BaseDatosObjeto bd;
    void Start()
    {       
       // Limpio los campos y asigno los campos a las variables
        ApellidoColumna.text = "";
        NombreColumna.text = "";
        GmailColumna.text = "";
        NotaColumna.text = "";
        IdentificacionColumna.text = "";
        EdadColumna.text = "";

        string datos = File.ReadAllText(Application.dataPath + "/StreamingAssets/estudiantes.json"); /*Se ubica la ruta en la que se encuentra el JSON*/
        bd = JsonUtility.FromJson<BaseDatosObjeto>(datos);

       foreach (Objeto estudiantes in bd.baseDatos)
        {
            IdentificacionColumna.text = IdentificacionColumna.text + estudiantes.identificacion.ToString() + "\n";
            NombreColumna.text = NombreColumna.text + estudiantes.nombre + "\n";
            ApellidoColumna.text = ApellidoColumna.text + estudiantes.apellido + "\n";
            GmailColumna.text = GmailColumna.text + estudiantes.gmail + "\n";
            EdadColumna.text = EdadColumna.text + estudiantes.edad.ToString() + "\n";
            NotaColumna.text = NotaColumna.text + estudiantes.nota.ToString() + "\n";
        }
    }

    /*Este codigo es en caso de que requiera buscar un objeto por su numero de identificacion*/
    /*public Objeto BucarOnjetoPorId(int identificacion)
    {
        return bd.baseDatos.Find(Objeto => Objeto.identificacion == identificacion);
    }*/
    public void EscenaCalificar()
    {
        Debug.Log("Si esta funcionando");
        SceneManager.LoadScene("QualifyStudents");
    }
}
