using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMouseController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if (hor != 0 || ver != 0)
        {
            ((CameraMover)Camera.main.GetComponent("CameraMover")).MoveMeBaby(hor, ver);
        }

        float scroll = -Input.mouseScrollDelta.y;
        if (scroll!=0)
        {
            ((CameraMover)Camera.main.GetComponent("CameraMover")).ZoomMe(scroll);
        }
    }
}
