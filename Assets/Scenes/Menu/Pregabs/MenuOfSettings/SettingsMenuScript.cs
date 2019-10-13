using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour
{

    public GameObject[] buttonGameObject;
    private Button[] buttonOnClick;
    public ButtonScript[] button;

    void Start()
    {
        button = new ButtonScript[buttonGameObject.Length];
        buttonOnClick = new Button[buttonGameObject.Length];
        for (int x = 0; x < buttonGameObject.Length; x++)
        {
            buttonOnClick[x] = buttonGameObject[x].GetComponent<Button>();
            button[x] = buttonGameObject[x].GetComponent<ButtonScript>();

            button[x].initButton();

            button[x] = buttonOnClick[x].GetComponent<ButtonScript>();
            button[x].button = button;
            button[x].id = x;
            //buttonOnClick[x].onClick.AddListener();
        }
    }

    void Update()
    {
        
    }

    public void activeButton(ButtonScript button)
    {
        for(int x = 0; x < this.button.Length; x++)
        {
            this.button[x].isSelected = false;
        }
        button.isSelected = true;
    }
}
