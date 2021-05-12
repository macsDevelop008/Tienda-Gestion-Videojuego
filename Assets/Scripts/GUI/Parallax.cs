using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Parallax : MonoBehaviour
{
    //[SerializeField] RawImage _image;
    [SerializeField] float _speedParallax;

    private List<RawImage> _childrens;

    void Start()
    {
        
        getChildrenRawImages();   
    }

    void Update() 
    {
        runParallax();
    }

    public void runParallax()
    {
        foreach(RawImage a in _childrens)
        {
            a.uvRect = new Rect(a.uvRect.x + _speedParallax * Time.deltaTime, 0.0f, 1.0f, 1.0f);
        }
    }

    private void getChildrenRawImages()
    {
        _childrens = new List<RawImage>();
        for(int i = 0; i < this.transform.childCount; i++)
        {
            RawImage rawImage = this.transform.GetChild(i).GetComponent<RawImage>();
            _childrens.Add(rawImage);
        }
    }

}