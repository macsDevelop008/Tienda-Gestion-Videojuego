using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemDescriptionController : MonoBehaviour
{
    public static ItemDescriptionController Shared;

    [SerializeField] Color _colorPositivo, _colorNegativo, _colorNeutral;
    [SerializeField] Image _imageItem;
    [SerializeField] Text _textFuerza;
    [SerializeField] Text _textAgilidad;
    [SerializeField] Text _textMana;

    private void Awake()
    {
        Shared = this;
    }
    public void MostrarEstadisticasItemSeleccionado(Item item) 
    {
        _imageItem.sprite = item._sprite;
        //Fuerza
        _textFuerza.text = item._force.ToString();
        _textFuerza.color = calcularColorTextoEstadistica(item._force);
        //Agilidad
        _textAgilidad.text = item._agility.ToString();
        _textAgilidad.color = calcularColorTextoEstadistica(item._agility);
        //Mana
        _textMana.text = item._mana.ToString();
        _textMana.color = calcularColorTextoEstadistica(item._mana);

    }

    Color calcularColorTextoEstadistica(float valor) 
    {
        if (valor < 0)
        {
            return _colorNegativo;
        }
        else
        if (valor > 0)
        {
            return _colorPositivo;
        }
        else
        {
            return _colorNeutral;
        }
    }
}
