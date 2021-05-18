using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosStoreItems : MonoBehaviour
{
    [SerializeField] GameObject _panelMainMenu;
    [SerializeField] GameObject _panelStoreMoney;

    public void Atras() 
    {
        _panelMainMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void AbrirStoreMoney() 
    {
        _panelStoreMoney.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
