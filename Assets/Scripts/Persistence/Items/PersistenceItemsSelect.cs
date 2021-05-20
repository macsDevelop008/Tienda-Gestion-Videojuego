using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceItemsSelect : MonoBehaviour
{
    public static PersistenceItemsSelect Shared;

    //Dar llave items seleccionados
    public string DarLlaveCascoSeleccionado() { return PlayerPrefs.GetString(Persistencia().DarLlaveCascoSeleccionado()); }
    public string DarLlavePecheraSeleccionado() { return PlayerPrefs.GetString(Persistencia().DarLlavePecheraSeleccionado()); }
    public string DarLlaveGuantesSeleccionado() { return PlayerPrefs.GetString(Persistencia().DarLlaveGuantesSeleccionado()); }
    public string DarLlaveBotasSeleccionado() { return PlayerPrefs.GetString(Persistencia().DarLlaveBotasSeleccionado()); }
    public string DarLlaveHabilidadSeleccionado() { return PlayerPrefs.GetString(Persistencia().DarLlaveHabilidadSeleccionado()); }


    private void Awake()
    {
        Shared = this;
    }

    PersistenceManager Persistencia() 
    {
        return PersistenceManager.Shared;
    }

    //Modificar items seleccionados
    public void ModificarCascoSeleccionado(Item item) 
    {
        PlayerPrefs.SetString(
            Persistencia().DarLlaveCascoSeleccionado()
            , item._codigo
            );
    }
    public void ModificarPecheraSeleccionado(Item item)
    {
        PlayerPrefs.SetString(
            Persistencia().DarLlavePecheraSeleccionado()
            , item._codigo
            );
    }
    public void ModificarGuantesSeleccionado(Item item)
    {
        PlayerPrefs.SetString(
            Persistencia().DarLlaveGuantesSeleccionado()
            , item._codigo
            );
    }
    public void ModificarBotasSeleccionado(Item item)
    {
        print("ñamñam");
        PlayerPrefs.SetString(
            Persistencia().DarLlaveBotasSeleccionado()
            , item._codigo
            );
    }
    public void ModificarHabilidadSeleccionado(Item item)
    {
        PlayerPrefs.SetString(
            Persistencia().DarLlaveHabilidadSeleccionado()
            , item._codigo
            );
    }
    public void ModificarPoder1Seleccionado(Item item)
    {
        PlayerPrefs.SetString(
            Persistencia().DarLlavePoder1Seleccionado()
            , item._codigo
            );
    }
    public void ModificarPoder2Seleccionado(Item item)
    {
        PlayerPrefs.SetString(
            Persistencia().DarLlavePoder2Seleccionado()
            , item._codigo
            );
    }
    public void ModificarPoder3Seleccionado(Item item)
    {
        PlayerPrefs.SetString(
            Persistencia().DarLlavePoder3Seleccionado()
            , item._codigo
            );
    }

    
}
