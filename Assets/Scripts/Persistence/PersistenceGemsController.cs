using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceGemsController : MonoBehaviour
{
    string key;
    public static PersistenceGemsController Shared;

    private void Awake()
    {
        Shared = this;
    }

    private void Start()
    {
        key = PersistenceManager.Shared.DarLlaveCantidadGemasPersistencia();
    }

    /// <summary>
    /// Retorna la cantidad de gemas persistida
    /// </summary>
    /// <returns></returns>
    public int CantidadDeGemasPersistida() 
    {
        return PlayerPrefs.GetInt(key);
    }

    public void ModificaCantidadGemasPersistida(int num)
    {
        int cantidadNueva = CantidadDeGemasPersistida() + num;

        PlayerPrefs.SetFloat(key, cantidadNueva);
    }
}

