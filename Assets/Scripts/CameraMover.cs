using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditorInternal;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    //A variable for controlling camera zoom speed
    private int zoomSpeed;
    /// <summary>
    /// A function used for moving the camera.
    /// TODO: Make sure the camera is constrained so it never moves to far from the map.
    /// </summary>
    /// <param name="hor">A parameter indicating the amount of movement in the X axis (horizontal)</param>
    /// <param name="ver">A parameter indicating the amount of movement in the Y axis (vertical)</param>
    public void MoveMeBaby(float hor, float ver)
    {

        transform.position = new Vector3(transform.position.x + hor, transform.position.y + ver, transform.position.z);
    }

    /// <summary>
    /// A function used for scrolling the camera (zooming it).
    /// </summary>
    /// <param name="scroll">A parameter indicating the value of the zoom.</param>
    public void ZoomMe(float scroll)
    {
        if(((Camera)GetComponent("Camera")).orthographicSize<=2f && scroll<0 )
        {
            return;
        }
        else if(((Camera)GetComponent("Camera")).orthographicSize >= 10f && scroll > 0)
        {
            return;
        }
        float oldSize= ((Camera)GetComponent("Camera")).orthographicSize;
        ((Camera)GetComponent("Camera")).orthographicSize = Mathf.Lerp(oldSize, oldSize+ scroll*zoomSpeed,Time.deltaTime);
    }
}