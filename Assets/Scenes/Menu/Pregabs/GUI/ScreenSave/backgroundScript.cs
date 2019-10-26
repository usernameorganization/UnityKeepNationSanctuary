using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{

    private Animator animator;
    private int timer;

    void Start()
    {
        animator = GetComponent<Animator>();
        timer = 10;
    }

    void Update()
    {
        if (timer > 0) timer--;
        else
        {
            closeGameObject();
        }
    }

    public void closeGameObject()
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        if (!state.IsName("ShowTheCanvas"))
        {
            gameObject.SetActive(false);
        }
    }
}
