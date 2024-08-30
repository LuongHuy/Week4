using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    private int randomValue;
    public Renderer rend; 
     

    void Start()
    {
        i++;
        randomValue = Random.Range(150, 251);
    }

    void Update()
    {      
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i == randomValue)
        {
            if (rend != null)
            {
                rend.enabled = false;
            }
        }
        i++;  
    }
}