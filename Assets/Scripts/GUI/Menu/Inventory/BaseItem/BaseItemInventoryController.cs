using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItemInventoryController : MonoBehaviour
{
    public Item item { get; set; }

    public void Seleccionado() 
    {
        ItemDescriptionController.Shared.
                MostrarEstadisticasItemSeleccionado(item);
    }
}
