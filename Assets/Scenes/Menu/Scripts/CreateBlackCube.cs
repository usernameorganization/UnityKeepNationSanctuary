using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlackCube : MonoBehaviour
{
    public GameObject BlackCube;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(BlackCube,transform.position, transform.rotation);
        }
    }
}
