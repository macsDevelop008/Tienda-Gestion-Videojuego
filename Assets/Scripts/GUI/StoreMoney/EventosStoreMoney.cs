using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosStoreMoney : MonoBehaviour
{
    [SerializeField] GameObject _panelMenu;
    [SerializeField] GameObject _panelSotireItems;

    public void AtrasAlMenu()
    {
        _panelMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void AtrasAlStoreItems()
    {
        _panelSotireItems.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
