using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*Referenciar los atributos del obejto en las variables*/
[System.Serializable]
public class Objeto
{
    public int identificacion;
    public string nombre;
    public string apellido;
    public string gmail;
    public int edad;
    public int nota;
}

/*Realizar la alista de los objetos*/
[System.Serializable]
public class BaseDatosObjeto
{
    public List<Objeto> baseDatos;
    
}
