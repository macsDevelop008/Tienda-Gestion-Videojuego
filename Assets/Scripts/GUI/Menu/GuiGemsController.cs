using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiGemsController : MonoBehaviour
{
    public static GuiGemsController shared;

    public int NumeroGemasActual { get; set; }

    [SerializeField] Text _textGems;

    private void Awake()
    {
        shared = this;
    }

    private void Start()
    {
        //Llamar valor de la persistencia
        NumeroGemasActual = PersistenceGemsController.Shared.CantidadDeGemasPersistida();
        //Mostrar en pantalla
        MostrarEnPantallaGemas();
    }

    /// <summary>
    /// Muestra en pantalla el numero de gemas
    /// </summary>
    void MostrarEnPantallaGemas()
    {
        _textGems.text = NumeroGemasActual.ToString();
    }

    /// <summary>
    /// Modifica el numero de gemas siempre que esté en el rango
    /// 0 a 99999999
    /// </summary>
    public void ModificarNumeroGemasGUI(int pNuevasGemas) 
    {
        if (NumeroGemasActual >= 0 && NumeroGemasActual <= 99999999) 
        {
            NumeroGemasActual += pNuevasGemas;
            CorreccionCantidadGemas();
        }
    }
    /// <summary>
    /// Corrige el numero de gemas si está fuera del rango
    /// </summary>
    void CorreccionCantidadGemas() 
    {
        if (NumeroGemasActual < 0)
        {
            NumeroGemasActual = 0;
        } 
        else
        if (NumeroGemasActual > 99999999) 
        {
            NumeroGemasActual = 99999999;
        }

        ModificarCantidadGemasPersistencia();
        MostrarEnPantallaGemas();
    }

    void ModificarCantidadGemasPersistencia() 
    {
        PersistenceGemsController.Shared.ModificaCantidadGemasPersistida(NumeroGemasActual);
    }



}
