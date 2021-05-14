using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosGUI : MonoBehaviour
{
    [SerializeField] GameObject _panelMenuPrincipal;
    [SerializeField] GameObject _paneStoreItems;
    [SerializeField] GameObject _paneStoreMoney;

    public void Store() 
    {
        _panelMenuPrincipal.SetActive(false);
        _paneStoreMoney.SetActive(false);
        _paneStoreItems.SetActive(true);
    }

    //TESTEO
    public void MasOro()
    {
        GuiGoldController.shared.ModificarNumeroOroGUI(200);
    }

    public void MasGemas() 
    {
        GuiGemsController.shared.ModificarNumeroGemasGUI(200);
    }
}
