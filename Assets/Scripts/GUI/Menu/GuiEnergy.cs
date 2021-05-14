using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiEnergy : MonoBehaviour
{
    public static GuiEnergy Shared;

    [SerializeField] Text _energiaNum;
    [SerializeField] Slider _energiaSlider;


    private void Awake()
    {
        Shared = this;
    }

    void Start()
    {
        InicializarEnergiaActual();
    }

    public void InicializarEnergiaActual() 
    {
        //Valores persistidos
    }

    public void ModificarEnergia(float num)
    {
        _energiaNum.text = num.ToString()+"%";
        _energiaSlider.value = num;
    }
}
