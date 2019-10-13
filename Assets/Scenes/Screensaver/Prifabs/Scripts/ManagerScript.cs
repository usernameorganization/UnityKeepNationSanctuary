using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour
{
    public GameObject[] layer;
    public int delay;

    private int id;
    private bool isCheck;
    private int timer;

    private int delayTimer;

    private Animator backgroundImage;

    private GameObject backGround;
    private GameObject showingImage;

    public bool isAnimationPlaying(Animator animator, string nameAnimation)
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        return state.IsName(nameAnimation);

    }

    public void setObjects(int id)
    {
        showingImage = layer[id].transform.Find("1").gameObject;
        backGround = layer[id].transform.Find("2").gameObject;
        backgroundImage = backGround.GetComponent<Animator>();
    }

    public void activeAllAnimations()
    {
        setObjects(id);
        bool isActive = isAnimationPlaying(backgroundImage, "ShowTheCanvas");
        if (!isActive)
        {
            if (delayTimer <= 0)
            {
                layer[id].SetActive(false);
                id++;
                delayTimer = delay;
                if (id >= layer.Length)
                {
                    isCheck = false;
                    theEndAnimatons();
                }
                else
                {
                    setObjects(id);
                    backgroundImage.Play("ShowTheCanvas", 0);
                }
            }
            else
            {
                delayTimer--;
            }
        }
    }

    public void theEndAnimatons()
    {
        GlobalManager.idForSceneScreen = 0;
        SceneManager.LoadScene("Menu");
    }

    void Start()
    {
        timer = 10;
        delayTimer = delay;

        setObjects(0);

        backgroundImage.Play("ShowTheCanvas", 0);
        isCheck = true;
    }

    void Update()
    {
        if (timer > 0) timer--;
        else
        {
            if (isCheck)
            {
                if (delayTimer <= 0) delayTimer = 0;
                activeAllAnimations();
            }
        }
    }
}
