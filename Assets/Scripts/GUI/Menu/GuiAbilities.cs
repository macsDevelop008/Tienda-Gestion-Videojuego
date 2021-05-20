using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiAbilities : MonoBehaviour
{
    public static GuiAbilities Shared;

    //[SerializeField] Image _habilidad1;
    [SerializeField] Image _habilidad2;
    //[SerializeField] Image _habilidad3;

    private void Awake()
    {
        Shared = this;
    }

    private void Start()
    {
        InicializarHabilidadesSeleccionadas();
    }

    public void InicializarHabilidadesSeleccionadas() 
    {
        ModificasHabilidad2GUI(PlayerItemsController.Shared.Poder2());
    }

    /*public void ModificasHabilidad1GUI(Item item) 
    {
        _habilidad1.sprite = item._sprite;
    }*/
    public void ModificasHabilidad2GUI(Item item)
    {
        _habilidad2.sprite = item._sprite;
    }
    /*public void ModificasHabilidad3GUI(Item item)
    {
        _habilidad3.sprite = item._sprite;
    }*/
}
