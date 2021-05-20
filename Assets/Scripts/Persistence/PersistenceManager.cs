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
        
    }

    private void Start()
    {
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
            PlayerPrefs.SetString("PecheraSelec", "");
            PlayerPrefs.SetString("ZpatosSelec", "");
            PlayerPrefs.SetString("GuantesSelec", "");
            PlayerPrefs.SetString("LibHabiliSelec", "");
            PlayerPrefs.SetString("Poder1", "");
            PlayerPrefs.SetString("Poder2", "");
            PlayerPrefs.SetString("Poder3", "");
        }
    }


    //ORO
    public string DarLlaveCantidadOroPersistencia() { return "CantidadOro"; }
    
    //GEMAS
    public string DarLlaveCantidadGemasPersistencia(){ return "CantidadGemas"; }

    //ITEMS SELECCIONADOS
    public string DarLlaveCascoSeleccionado() {return "CascoSelec";}
    public string DarLlavePecheraSeleccionado() {return "PecheraSelec"; }
    public string DarLlaveBotasSeleccionado() {return "ZpatosSelec"; }
    public string DarLlaveGuantesSeleccionado() {return "GuantesSelec"; }
    public string DarLlaveHabilidadSeleccionado() {return "LibHabiliSelec"; }
    public string DarLlavePoder1Seleccionado() {return "Poder1"; }
    public string DarLlavePoder2Seleccionado() {return "Poder2"; }
    public string DarLlavePoder3Seleccionado() {return "Poder3"; }

}

