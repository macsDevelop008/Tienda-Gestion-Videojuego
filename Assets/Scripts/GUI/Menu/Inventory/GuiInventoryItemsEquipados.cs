using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiInventoryItemsEquipados : MonoBehaviour
{
    [SerializeField] Image _cascoEquipado;
    [SerializeField] Image _pecheraEquipado;
    [SerializeField] Image _guantesEquipado;
    [SerializeField] Image _botasEquipado;
    [SerializeField] Image _habilidadEquipado;
    [SerializeField] Image _poderEquipado;

    public void ModificarCascoGUIInventory(Item item)
    {
        _cascoEquipado.sprite = item._sprite;
    }

    public void ModificarPecheraGUIInventory(Item item)
    {
        _pecheraEquipado.sprite = item._sprite;

    }

    public void ModificarBotasGUIInventory(Item item)
    {
        _botasEquipado.sprite = item._sprite;

    }

    public void ModificarGuantesGUIInventory(Item item)
    {
        _guantesEquipado.sprite = item._sprite;

    }

    public void ModificarLibroHabilidadGUIInventory(Item item)
    {
        _habilidadEquipado.sprite = item._sprite;

    }
}
