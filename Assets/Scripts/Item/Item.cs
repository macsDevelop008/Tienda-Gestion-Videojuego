using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public enum TIPO
{
    CASCO, PECHERA,
    GUANTES, BOTAS,
    LIBROHABILIDAD
}
[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public Sprite _sprite;
    [Header("Tipo de Item")]
    public TIPO _tipoItem;
    [Header("Stats")]
    public float _force;
    public float _agility;
    public float _mana;
}
