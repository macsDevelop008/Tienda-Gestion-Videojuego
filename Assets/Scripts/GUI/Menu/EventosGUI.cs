using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosGUI : MonoBehaviour
{
    [SerializeField] GameObject _panelMenuPrincipal;
    [SerializeField] GameObject _panelStoreItems;
    [SerializeField] GameObject _panelStoreMoney;
    [SerializeField] GameObject _panelInventory;

    //TESTEO
    public void MasOro()
    {
        GuiGoldController.shared.ModificarNumeroOroGUI(200);
    }

    public void MasGemas() 
    {
        GuiGemsController.shared.ModificarNumeroGemasGUI(200);
    }
    //---------------

    public void AbrirPanelStoreItems() 
    {
        _panelStoreItems.SetActive(true);
        _panelMenuPrincipal.SetActive(false);
    }

    public void AbrirPanelStoreMoney()
    {
        _panelStoreMoney.SetActive(true);
        _panelMenuPrincipal.SetActive(false);
    }

    public void AbrirInventory() 
    {
        _panelInventory.SetActive(true);
    }
}
