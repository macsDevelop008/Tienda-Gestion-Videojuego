using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{
    //Llave                 Descripcion
    //---------------------------------
    //Main                  Llave principal, verifica si ya se crearon las otra llaves
    //
    //CantidadGemas         Numero de gemas
    //CantidadOro           Numero de oro
    //
    //CascoSelec            Casco seleccionado
    //PecgeraSelec          Pechera seleccionada
    //ZpatosSelec           Zapatos seleccionados
    //GuantesSelec          Guantes seleccionados
    //LibHabiliSelec        Libro de habilidad seleccionado
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
        //if (true) 
        {
            Debug.Log("<color=rgb(0,0,255)>CUIDADO: </color>Llaves persistencia creadas");

            PlayerPrefs.SetString("Main", "Creado");

            PlayerPrefs.SetInt("CantidadGemas", 0);
            PlayerPrefs.SetInt("CantidadOro", 0);

            PlayerPrefs.SetString("CascoSelec", "");
            PlayerPrefs.SetString("PecgeraSelec", "");
            PlayerPrefs.SetString("ZpatosSelec", "");
            PlayerPrefs.SetString("GuantesSelec", "");
            PlayerPrefs.SetString("LibHabiliSelec", "");
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

