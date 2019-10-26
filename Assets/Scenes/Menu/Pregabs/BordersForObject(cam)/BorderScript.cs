using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{
    public GameObject MainBorder;
    public Camera cam;
    public float camWidth;
    public float camHeight;
    void Start()
    {
        camWidth = cam.ViewportToWorldPoint(new Vector2(1, 0)).x - cam.ViewportToWorldPoint(new Vector2(0, 0)).x;
        camHeight = cam.ViewportToWorldPoint(new Vector2(0, 1)).y - cam.ViewportToWorldPoint(new Vector2(0, 0)).y;

    }
    void Update()
    {
    }
    public void intersection()
    {
        print(camHeight);
        if (transform.position.x + camWidth / 2 > MainBorder.GetComponent<Renderer>().bounds.max.x)
        {
            transform.position = new Vector3(MainBorder.GetComponent<Renderer>().bounds.max.x - camWidth / 2, transform.position.y, transform.position.z);
        }
        if (transform.position.x - camWidth / 2 < MainBorder.GetComponent<Renderer>().bounds.min.x)
        {
            transform.position = new Vector3(MainBorder.GetComponent<Renderer>().bounds.min.x + camWidth / 2, transform.position.y, transform.position.z);
        }
        if (transform.position.y + camHeight / 2 > MainBorder.GetComponent<Renderer>().bounds.max.y)
        {
            transform.position = new Vector3(transform.position.x, MainBorder.GetComponent<Renderer>().bounds.max.y - camHeight / 2, transform.position.z);
        }
        if (transform.position.y - camHeight / 2 < MainBorder.GetComponent<Renderer>().bounds.min.y)
        {
            transform.position = new Vector3(transform.position.x, MainBorder.GetComponent<Renderer>().bounds.min.y + camHeight / 2, transform.position.z);
        }
    }
}
