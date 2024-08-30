using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;

    public Renderer rend;  

    void Start()
    {
        i++; 
    }

    void Update()
    {      
        Debug.Log(gameObject.name + ":" + i);
        i++;  
    }
}