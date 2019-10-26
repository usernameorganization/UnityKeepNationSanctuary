using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamScript : MonoBehaviour
{
    public Camera cam;
    public Vector3 startCamerapPosition;
    private GameObject ManagerMenu;
    private BorderScript borderScript;
    public GameObject menuOfSettings;
    void Start()
    {
        borderScript = GetComponent<BorderScript>();
        ManagerMenu = GameObject.FindGameObjectWithTag("MenuManager");
    }

    void Update()
    {
        if(GetComponent<GUIscript>().indexOfLayer == GlobalManager.GuiIndexLayer)
        MapDrag();
        borderScript.intersection();
    }

    public void MapDrag()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            startCamerapPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 moPos = cam.ScreenToWorldPoint(Input.mousePosition) - startCamerapPosition;
            transform.position = new Vector3(transform.position.x - moPos.x, transform.position.y - moPos.y, transform.position.z);
        }
    }
    public void MapIsInBorders()
    {
        for(int i = 0; i < ManagerMenu.GetComponent<MenuManagerScript>().MapBg.Length; i++)
        {
            if (transform.position.x > ManagerMenu.GetComponent<MenuManagerScript>().MapBg[i].transform.position.x & ManagerMenu.GetComponent<MenuManagerScript>().MapBg[i].active == true)
            {
                transform.position = new Vector3(ManagerMenu.GetComponent<MenuManagerScript>().MapBg[i].transform.position.x, transform.position.y, transform.position.z);
            }
        }
    }
}
