using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public bool isSelected;
    private GameObject menu;
    private SettingsMenuScript menuScript;

    public ButtonScript[] button;
    public int id;

    void Start()
    {

    }

    public void initButton()
    {
        menu = GameObject.FindGameObjectWithTag("SettingsMenu");
        menuScript = GameObject.FindGameObjectWithTag("SettingsMenu").GetComponent<SettingsMenuScript>();
        button = menuScript.button;
        Button buttonOnGameObject = GetComponent<Button>();
        buttonOnGameObject.onClick.AddListener(activeButton);
    }

    void Update()
    {
        
    }

    public void activeButton()
    {
        for(int x = 0; x < button.Length; x++)
        {
            button[x].isSelected = false;
            if(button[x] != gameObject)
            {
                button[x].activeAnimationNormal();
            }
        }

        isSelected = true;
        menu.GetComponent<SelectedButtonScript>().buttonSelected = gameObject;
        activeAnimationSelected();
    }

    public void activeAnimationSelected()
    {
        Animator animator = GetComponent<Animator>();
        animator.Play("Selected", 0);
    }

    public void activeAnimationNormal()
    {
        Animator animator = GetComponent<Animator>();
        animator.Play("Normal", 0);
    }
}
