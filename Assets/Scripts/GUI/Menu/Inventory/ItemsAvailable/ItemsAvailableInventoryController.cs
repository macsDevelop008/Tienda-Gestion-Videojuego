using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemsAvailableInventoryController : MonoBehaviour
{
    public static ItemsAvailableInventoryController Shared;

    [SerializeField] Transform _contenedorInventory;
    [SerializeField] GameObject _baseItem;

    
    ItemsManager Items() 
    {
        return ItemsManager.Shared;
    }

    private void Awake()
    {
        Shared = this;
    }

    private void OnEnable()
    {
        DesocuparContenedoraItems();
        DesplegarTodosItemsDisponibles();
    }

    void InstanciarItem(Item item) 
    {
        GameObject o = Instantiate(_baseItem, _contenedorInventory);
        ModificarImagenItem(o, item._sprite);
    }

    void ModificarImagenItem(GameObject item, Sprite imagen) 
    {
        item.transform.GetChild(0).GetComponent<Image>().sprite = imagen;
    }

    public void DesplegarTodosItemsDisponibles() 
    {
        DesocuparContenedoraItems();
        for (int i = 0; i < items().Length; i++) 
        {
            InstanciarItem(items()[i]);
        }
    }

    public void DesplegarSegunTipoItemDisponibles(TIPO tipoItem) 
    {
        DesocuparContenedoraItems();

        for (int i = 0; i < items().Length; i++)
        {
            if (items()[i]._tipoItem == tipoItem) 
            {
                InstanciarItem(items()[i]);
            }
        }

    }

    Item[] items() 
    {
        return Items().ItemsParaInventario().ToArray();
    }

    void DesocuparContenedoraItems() 
    {
        for (int i = 0; i < _contenedorInventory.childCount; i++) 
        {
            Destroy(_contenedorInventory.GetChild(i).gameObject);
        }
    }
}
