using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedButtonScript : MonoBehaviour
{

    public GameObject[] allButtons;
    public GameObject buttonSelected;

    void Start()
    {
        allButtons = GetComponent<SettingsMenuScript>().buttonGameObject;
    }

    void Update()
    {
        
    }
}
