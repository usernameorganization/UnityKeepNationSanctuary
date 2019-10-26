using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerScript : MonoBehaviour
{

    public GameObject[] background;
    public GameObject[] MapBg = new GameObject[7];
    public int MapBgIsActive;
    void Start()
    {
        activeAnimation(background[GlobalManager.idForSceneScreen]);
    }

    void Update()
    {
        MapBgActivation();
    }

    public void activeAnimation(GameObject background)
    {
        background.SetActive(true);
        Animator animator = background.GetComponent<Animator>();
        animator.Play("ShowTheCanvas", 0);
    }
    public void MapBgActivation()
    {
        for(int i = 0; i < MapBg.Length; i++)
        {
            if (i == MapBgIsActive)
            {
                MapBg[i].SetActive(true);
            }
            else MapBg[i].SetActive(false);
        }
    }

}

