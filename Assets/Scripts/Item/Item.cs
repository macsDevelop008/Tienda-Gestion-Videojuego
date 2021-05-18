using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public enum TIPO
{
    CASCO, PECHERA,
    GUANTES, BOTAS,
    HABILIDAD, PODER
}
[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    [Header("Codigo")]
    public string _codigo;
    [Header("Precios")]
    public float _precioGemas;
    public float _precioOro;
    [Header("Imagen")]
    public Sprite _sprite;
    [Header("Tipo de Item")]
    public TIPO _tipoItem;
    [Header("Stats")]
    public float _force;
    public float _agility;
    public float _mana;
}
