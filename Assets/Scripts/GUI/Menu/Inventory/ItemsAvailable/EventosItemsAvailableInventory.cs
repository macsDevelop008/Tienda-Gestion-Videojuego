using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosItemsAvailableInventory : MonoBehaviour
{
    ItemsAvailableInventoryController itemsOrgaInventoy() 
    {
        return ItemsAvailableInventoryController.Shared;
    }

    public void DesplegarTodosItems() 
    {
        itemsOrgaInventoy().DesplegarTodosItemsDisponibles();
    }

    public void DesplegarCascos() 
    {
        itemsOrgaInventoy().DesplegarSegunTipoItemDisponibles(TIPO.CASCO);
    }

    public void DesplegarPecheras()
    {
        itemsOrgaInventoy().DesplegarSegunTipoItemDisponibles(TIPO.PECHERA);
    }

    public void DesplegarGuantes()
    {
        itemsOrgaInventoy().DesplegarSegunTipoItemDisponibles(TIPO.GUANTES);
    }

    public void DesplegarBotas()
    {
        itemsOrgaInventoy().DesplegarSegunTipoItemDisponibles(TIPO.BOTAS);
    }

    public void DesplegarHabilidades()
    {
        itemsOrgaInventoy().DesplegarSegunTipoItemDisponibles(TIPO.HABILIDAD);
    }

    public void DesplegarPoderes()
    {
        itemsOrgaInventoy().DesplegarSegunTipoItemDisponibles(TIPO.PODER);
    }
}
