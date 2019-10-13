using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerScript : MonoBehaviour
{

    public GameObject[] background;

    void Start()
    {
        activeAnimation(background[GlobalManager.idForSceneScreen]);
    }

    void Update()
    {
        
    }

    public void activeAnimation(GameObject background)
    {
        background.SetActive(true);
        Animator animator = background.GetComponent<Animator>();
        animator.Play("ShowTheCanvas", 0);
    }
}
