using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMap : MonoBehaviour
{
    public bool IsActive;
    void Update()
    {
        Activation();
    }
     public void Activation()
    {
        gameObject.SetActive(IsActive);
    }
}
