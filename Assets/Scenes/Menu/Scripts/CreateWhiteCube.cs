using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWhiteCube : MonoBehaviour
{
    public GameObject WhiteCube;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(WhiteCube, transform.position, transform.rotation);
        }  
    }
}
