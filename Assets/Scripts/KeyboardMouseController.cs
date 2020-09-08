using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMouseController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //A part of code for moving detecting the pressing of arrow ar WASD keys.
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if (hor != 0 || ver != 0)
        {
            ((CameraMover)Camera.main.GetComponent("CameraMover")).MoveMeBaby(hor, ver);
        }


        //A part of code for detecting the use of a mouse wheel.
        float scroll = -Input.mouseScrollDelta.y;
        if (scroll!=0)
        {
            
            ((CameraMover)Camera.main.GetComponent("CameraMover")).ZoomMe(scroll);
        }
    }
}
