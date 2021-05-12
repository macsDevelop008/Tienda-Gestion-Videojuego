using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceGoldController : MonoBehaviour
{
    string key;
    public static PersistenceGoldController Shared;

    private void Awake()
    {
        Shared = this;
    }

    private void Start()
    {
        key = PersistenceManager.Shared.DarLlaveCantidadOroPersistencia();
    }

    /// <summary>
    /// Retorna la cantidad de oro persistida
    /// </summary>
    /// <returns></returns>
    public int CantidadDeOroPersistida()
    {
        return PlayerPrefs.GetInt(key);
    }

    public void ModificaCantidadOroPersistida(int num)
    {
        int cantidadNueva = CantidadDeOroPersistida() + num;

        PlayerPrefs.SetFloat(key, cantidadNueva);
    }
}
