using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public static int targetFrameRate;
    [SerializeField]
    private GameObject blueObj;
    
    public GameObject redObj;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Instantiate(redObj, new Vector3(2,0,0), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
