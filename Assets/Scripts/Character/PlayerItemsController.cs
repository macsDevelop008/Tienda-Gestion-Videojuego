using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemsController : MonoBehaviour
{
    public static PlayerItemsController Shared;


    private void Awake()
    {
        Shared = this;
    }
    private void Start()
    {
        //print(BuscarItemSeleccionado(PersistenceItemsSelect.Shared.DarLlaveCascoSeleccionado())._codigo);
    }
    public Item Casco() 
    {
        
        return BuscarItemSeleccionado(PersistenceItemsSelect.Shared.DarLlaveCascoSeleccionado());
    }
    public Item Pechera()
    {
        return BuscarItemSeleccionado(PersistenceItemsSelect.Shared.DarLlavePecheraSeleccionado());
    }
    public Item Guantes()
    {
        return BuscarItemSeleccionado(PersistenceItemsSelect.Shared.DarLlaveGuantesSeleccionado());
    }
    public Item Botas()
    {
        return BuscarItemSeleccionado(PersistenceItemsSelect.Shared.DarLlaveBotasSeleccionado());
    }
    public Item Habilidad()
    {
        return BuscarItemSeleccionado(PersistenceItemsSelect.Shared.DarLlaveHabilidadSeleccionado());
    }
    public Item Poder2()
    {
        return BuscarItemSeleccionado(PersistenceItemsSelect.Shared.DarLlavePoderSeleccionado());
    }


    //Retorna item segun llave de persistencia
    public Item BuscarItemSeleccionado(string llaveItem) 
    {

        Item item = null;
        Item[] array = ItemsManager.Shared.ItemsParaInventario().ToArray();

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i]._codigo.Equals(llaveItem))
            {
                return array[i];
            }
        }

        return item;
    }
}
