using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiItems : MonoBehaviour
{
    public static GuiItems Shared;

    [SerializeField] Image _imagenCaso;
    [SerializeField] Image _imagenPechera;
    [SerializeField] Image _imagenZapatos;
    [SerializeField] Image _imagenGuantes;
    [SerializeField] Image _imagenLibroHabilidad;


    private void Start()
    {
        InicializarItemsSeleccionadosGUI();
    }
    public void InicializarItemsSeleccionadosGUI() 
    {
        ModificarCascoGUI(PlayerItemsController.Shared.Casco());
        ModificarPecheraGUI(PlayerItemsController.Shared.Pechera());
        ModificarBotasGUI(PlayerItemsController.Shared.Botas());
        ModificarGuantesGUI(PlayerItemsController.Shared.Guantes());
        ModificarLibroHabilidadGUI(PlayerItemsController.Shared.Habilidad());
    }

    public void ModificarCascoGUI(Item item) 
    {
        _imagenCaso.sprite = item._sprite;
    }

    public void ModificarPecheraGUI(Item item)
    {
        _imagenPechera.sprite = item._sprite;

    }

    public void ModificarBotasGUI(Item item)
    {
        _imagenZapatos.sprite = item._sprite;

    }

    public void ModificarGuantesGUI(Item item)
    {
        _imagenGuantes.sprite = item._sprite;

    }

    public void ModificarLibroHabilidadGUI(Item item)
    {
        _imagenLibroHabilidad.sprite = item._sprite;

    }
}
