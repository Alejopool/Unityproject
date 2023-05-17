using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{  
    /*Con esta funcion se ingresa a la escena de StudentList,
     y se aplica en el boton de Lista en la escena MainMenu*/
    public void ListaEstudiantes() 
    {
        SceneManager.LoadScene("StudentsList");
    }

    /*Con esta funcion se pretende salir del aplicativo, 
     * se encuentra en la escena MainMenu en el boton Salir*/
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliste del aplicativo");
    }
}
