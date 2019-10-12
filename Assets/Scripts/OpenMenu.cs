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
        
    }

    public void buttonMethod()
    {
        if (isOpen)
        {
            animator.SetBool("isOpen", isOpen);
            isOpen = false;
        }
        else
        {
            animator.SetBool("isOpen", isOpen);
            isOpen = true;
        }
    }
}
