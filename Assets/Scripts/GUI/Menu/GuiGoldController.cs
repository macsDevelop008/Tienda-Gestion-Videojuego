using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiGoldController : MonoBehaviour
{
    public static GuiGoldController shared;

    public int NumeroOroActual { get; set; }

    [SerializeField] Text _textOro;

    private void Awake()
    {
        shared = this;
    }

    private void Start()
    {
        //Llamar valor de la persistencia
        NumeroOroActual = PersistenceGoldController.Shared.CantidadDeOroPersistida();
        //Mostrar en pantalla
        MostrarEnPantallaOro();

    }

    /// <summary>
    /// Muestra en pantalla el numero de gemas
    /// </summary>
    void MostrarEnPantallaOro()
    {
        _textOro.text = NumeroOroActual.ToString();
    }

    /// <summary>
    /// Modifica el numero de oro siempre que esté en el rango
    /// 0 a 99999999
    /// </summary>
    public void ModificarNumeroGemasGUI(int pNuevasGemas)
    {
        if (NumeroOroActual >= 0 && NumeroOroActual <= 99999999)
        {
            NumeroOroActual += pNuevasGemas;
            CorreccionCantidadOro();
        }
    }

    /// <summary>
    /// Corrige el numero de oro si está fuera del rango
    /// </summary>
    void CorreccionCantidadOro()
    {
        if (NumeroOroActual < 0)
        {
            NumeroOroActual = 0;
        }
        else
        if (NumeroOroActual > 99999999)
        {
            NumeroOroActual = 99999999;
        }

        ModificarCantidadOroPersistencia();
        MostrarEnPantallaOro();
    }

    void ModificarCantidadOroPersistencia()
    {
        PersistenceGoldController.Shared.ModificaCantidadOroPersistida(NumeroOroActual);
    }

}
