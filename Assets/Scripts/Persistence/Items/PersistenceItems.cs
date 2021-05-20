using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceItems : MonoBehaviour
{
    public static PersistenceItems Shared;

    [SerializeField] Item[] _itemsIniciales;

    private List<Item> _itemsPersistidos, _itemsNoPersistidos;

    private void Awake()
    {
        Shared = this;
        _itemsPersistidos = new List<Item>();
        _itemsNoPersistidos = new List<Item>();
        
    }

    private void Start()
    {
        PersistirItemsIniciales();
    }

    //Items Iniciales
    public void PersistirItemsIniciales() 
    {
        if (!PlayerPrefs.HasKey("ItemsIniciales"))
        //if (true)
        {
            Debug.Log("<color=rgb(0,0,255)>CUIDADO: </color>Llaves persistencia Items creadas");

            PlayerPrefs.SetString("ItemsIniciales", "Creado");

            for (int i = 0; i < _itemsIniciales.Length; i++) 
            {
                PersistirItem(_itemsIniciales[i]);

                //Persistir en item seleccionados
                if (_itemsIniciales[i]._tipoItem == TIPO.CASCO) 
                {
                    PersistenceItemsSelect.Shared.ModificarCascoSeleccionado(_itemsIniciales[i]);                  
                }
                if (_itemsIniciales[i]._tipoItem == TIPO.PECHERA)
                {
                    PersistenceItemsSelect.Shared.ModificarPecheraSeleccionado(_itemsIniciales[i]);
                }
                if (_itemsIniciales[i]._tipoItem == TIPO.GUANTES)
                {
                    PersistenceItemsSelect.Shared.ModificarGuantesSeleccionado(_itemsIniciales[i]);
                }
                if (_itemsIniciales[i]._tipoItem == TIPO.BOTAS)
                {
                    PersistenceItemsSelect.Shared.ModificarBotasSeleccionado(_itemsIniciales[i]);
                }
                if (_itemsIniciales[i]._tipoItem == TIPO.HABILIDAD)
                {
                    PersistenceItemsSelect.Shared.ModificarHabilidadSeleccionado(_itemsIniciales[i]);
                }
            }
        }
    }

    //Crear persistencia item por codigo
    public void PersistirItem(Item item) 
    {
        if (!PlayerPrefs.HasKey(item._codigo)) 
        {
            PlayerPrefs.SetString(item._codigo, item._codigo);
        }
    }

    //Verificar existencia de item persistido
    public bool ExistenciaItemEnPersistencia(Item item) 
    {
        if (PlayerPrefs.HasKey(item._codigo))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Retornar lista de items persistidos, parametro lista de todos los items disponibles en la aplicacion
    public List<Item> ListadoItemsPersisitdos(Item[] listadoTodoItemsPosibles) 
    {
        for (int i = 0; i < listadoTodoItemsPosibles.Length; i++) 
        {
            if (ExistenciaItemEnPersistencia(listadoTodoItemsPosibles[i])) 
            {
                _itemsPersistidos.Add(listadoTodoItemsPosibles[i]);
            }           
        }
        return _itemsPersistidos;
    }

    //Retornar lista de items no persistidos, parametro lista de todos los items disponibles en la aplicacion
    public List<Item> ListadoItemsNoPersisitdos(Item[] listadoTodoItemsPosibles)
    {
        for (int i = 0; i < listadoTodoItemsPosibles.Length; i++)
        {
            if (!ExistenciaItemEnPersistencia(listadoTodoItemsPosibles[i]))
            {
                _itemsNoPersistidos.Add(listadoTodoItemsPosibles[i]);               
            }
        }

        return _itemsNoPersistidos;
    }
}
