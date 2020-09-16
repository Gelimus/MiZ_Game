using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KeyboardMouseController : MonoBehaviour
{
    Vector3 oldMousePosition;
    //The higher number the less sensitive the pan. Used for panning by mouse dragging
    int cameraPanSensivity = 120;

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
        if (scroll != 0)
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            pointerData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            //foreach (RaycastResult result in results)
            //{
            //    Debug.Log("Hit " + result.gameObject.name);
            //}

            if (results.Count == 0)
            {
                ((CameraMover)Camera.main.GetComponent("CameraMover")).ZoomMe(scroll);
            }
            
        }


        if (Input.GetMouseButtonDown(0))
        {
            oldMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            
            hor = (oldMousePosition.x-Input.mousePosition.x)/cameraPanSensivity;
            ver = (oldMousePosition.y-Input.mousePosition.y)/cameraPanSensivity;
            
            ((CameraMover)Camera.main.GetComponent("CameraMover")).MoveMeBaby(hor, ver);
            oldMousePosition = Input.mousePosition;
        }

    }
}
