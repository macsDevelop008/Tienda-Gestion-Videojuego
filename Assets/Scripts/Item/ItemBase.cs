using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    [SerializeField] Image _imagePrefab;

    public Image Imagen { get { return this._imagePrefab; } set { this._imagePrefab = value; } }
}
