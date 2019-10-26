using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMenu : MonoBehaviour
{

    public Button button;

    private bool isOpen;
    public Animator animator;

    public void Start()
    {
        button.onClick.AddListener(buttonMethod);
        isOpen = true;
    }

    public void Update()
    {
        print(isOpen);
        if (GetComponent<GUIscript>().indexOfLayer != GlobalManager.GuiIndexLayer & isOpen == false)
        {
            animator.SetBool("isOpen", isOpen);
            isOpen = false;
        }
    }

    public void buttonMethod()
    {

        if (isOpen)
        {
            GlobalManager.GuiIndexLayer = GetComponent<GUIscript>().indexOfLayer;
            if (GetComponent<GUIscript>().indexOfLayer == GlobalManager.GuiIndexLayer)
            {
                animator.SetBool("isOpen", isOpen);
                isOpen = false;
            }
        }
        else
        {
                animator.SetBool("isOpen", isOpen);
                isOpen = true;
                GlobalManager.GuiIndexLayer = 0;
        }
    }
}
