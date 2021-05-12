using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{
    //Llave                 Descripcion
    //---------------------------------
    //Main                  Llave principal, verifica si ya se crearon las otra llaves
    //CantidadGemas         Numero de gemas
    //CantidadOro           Numero de oro
    //--------------------------------

    public static PersistenceManager Shared;

    void Awake()
    {
        Shared = this;
        CrearLlaves();
    }

    /// <summary>
    /// Crea las llaves, si no existen aun
    /// </summary>
    void CrearLlaves() 
    {
        if (!PlayerPrefs.HasKey("Main")) 
        {
            PlayerPrefs.SetString("Main", "");

            PlayerPrefs.SetInt("CantidadGemas", 0);
            PlayerPrefs.SetInt("CantidadOro", 0);
        }
    }


    //ORO
    public string DarLlaveCantidadOroPersistencia() 
    {
        return "CantidadOro";
    }
    //GEMAS
    public string DarLlaveCantidadGemasPersistencia()
    {
        return "CantidadGemas";
    }
}

