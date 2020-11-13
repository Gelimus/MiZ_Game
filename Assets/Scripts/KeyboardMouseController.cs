using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KeyboardMouseController : MonoBehaviour
{
    Vector3 oldMousePosition;
    //The higher number the less sensitive the pan. Used for panning by mouse dragging
    int cameraPanSensitivity = 120;
    bool dragStarted = false;
    float dragDelay = 0.12f;
    float clickDuration;

    MapController mapController;
    UIController uiController;

    void Start()
    {
        mapController=gameObject.GetComponent<MapController>();
        uiController = gameObject.GetComponent<UIController>();
    }

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
            if (!CheckIfOverUI())
            {
                ((CameraMover)Camera.main.GetComponent("CameraMover")).ZoomMe(scroll);
            }
            
        }
        
        if (!CheckIfOverUI())
        {
            if (Input.GetMouseButtonDown(0))
            {
                dragStarted = true;
                clickDuration = 0f;
            }
        }
        if (Input.GetMouseButton(0) && dragStarted)
        {
            clickDuration += Time.deltaTime;
            if (clickDuration > dragDelay)
            {
                hor = (oldMousePosition.x - Input.mousePosition.x) / cameraPanSensitivity;
                ver = (oldMousePosition.y - Input.mousePosition.y) / cameraPanSensitivity;

                ((CameraMover)Camera.main.GetComponent("CameraMover")).MoveMeBaby(hor, ver);
                oldMousePosition = Input.mousePosition;
            }
            else
            {
                oldMousePosition = Input.mousePosition;
            }
 
        }
        if (Input.GetMouseButtonUp(0))
        {
             dragStarted = false;
            if (clickDuration <= dragDelay)
            {
                Debug.Log("Click");
                //Check what was clicked.
                Vector3 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit[] rh = Physics.RaycastAll(origin, Vector3.forward);
                if (rh.Length == 0)
                {
                    return;
                }
                for (int i = 0; i < rh.Length; i++)
                {
                    if (rh[i].collider.gameObject.name == "InnerMapHolder")
                    {
                        Debug.Log(origin);
                        Debug.Log(mapController.activeSite.map[(int)Mathf.Abs(origin.y - 0.5f), (int)(origin.x + 0.5f)].xCoord + " x " + (mapController.activeSite.map[(int)Mathf.Abs(origin.y - 0.5f), (int)(origin.x + 0.5f)].yCoord));
                        uiController.ChangeSelectedRoom(mapController.activeSite.map[(int)Mathf.Abs(origin.y - 0.5f), (int)(origin.x + 0.5f)].room);
                    }
                    if(rh[i].collider.transform.parent.name== "furnitureHolder")
                    {
                        Debug.Log("I got a furniture! It is " + rh[i].collider.gameObject.name);
                    }
                }
                
            }
        }
       
    }
    private bool CheckIfOverUI()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);
        if (results.Count == 0)
        {
            return false;
        }
        return true;
    }
}
