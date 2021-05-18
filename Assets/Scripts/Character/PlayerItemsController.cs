using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemsController : MonoBehaviour
{
    public static PlayerItemsController Shared;

    private Item _casco;
    private Item _pechera;
    private Item _guantes;
    private Item _zapatos;
    private Item _habilidad;

    private Item _poder1, _poder2, _poder3;

    private void Awake()
    {
        Shared = this;
    }

    public Item Casco { get { return _casco; } set { _casco = value; } }
    public Item Pechera { get { return _pechera; } set { _pechera = value; } }
    public Item Guantes { get { return _guantes; } set { _guantes = value; } }
    public Item Zapatos { get { return _zapatos; } set { _zapatos = value; } }
    public Item Habilidad { get { return _habilidad; } set { _habilidad = value; } }
    public Item Poder1 { get { return _poder1; } set { _poder1 = value; } }
    public Item Poder2 { get { return _poder2; } set { _poder2 = value; } }
    public Item Poder3 { get { return _poder3; } set { _poder3 = value; } }

    void ItemsSeleccionados() 
    {

    }
}
