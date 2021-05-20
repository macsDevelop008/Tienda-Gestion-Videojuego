using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    public static ItemsManager Shared;

    [SerializeField] Item[] _itemsCascos, _itemsPecheras,
                                _itemsGuantes, _itemsBotas,
                                        _itemsHabilidades, _itemsTecnicas;

    Item[] _allItems;
    List<Item> _listaToInventario, _listaToTienda;

    private void Awake()
    {
        Shared = this;
        _listaToInventario = new List<Item>();
        _listaToTienda = new List<Item>();
        UnirAllItemsArray();
        LlenarLista_Inventario_Tienda();
    }

    private void Start()
    {

    }

    //Unir arrays de items
    void UnirAllItemsArray() 
    {
        List<Item> items = new List<Item>();

        items.AddRange(_itemsCascos);
        items.AddRange(_itemsPecheras);
        items.AddRange(_itemsGuantes);
        items.AddRange(_itemsBotas);
        items.AddRange(_itemsHabilidades);
        items.AddRange(_itemsTecnicas);

        _allItems = items.ToArray();
    }

    //Llena la lista de items para el inventario y para la tienda
    public void LlenarLista_Inventario_Tienda() 
    {
        _listaToInventario = PersistenceItems.Shared.ListadoItemsPersisitdos(_allItems);
        _listaToTienda = PersistenceItems.Shared.ListadoItemsNoPersisitdos(_allItems);
    }

    //Items disponibles para el inventario
    public List<Item> ItemsParaInventario() 
    {
        return _listaToInventario;
    }

    //Items disponibles para la tienda
    public List<Item> ItemsParaTienda()
    {
        return _listaToTienda;
    }
}
