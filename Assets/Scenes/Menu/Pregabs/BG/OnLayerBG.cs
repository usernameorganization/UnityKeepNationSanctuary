using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnLayerBG : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnBGLayer);
    }

    void Update()
    {

    }
    public void OnBGLayer()
    {
        GlobalManager.GuiIndexLayer = 0;
    }
}
