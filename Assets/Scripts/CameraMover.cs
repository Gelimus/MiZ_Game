using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditorInternal;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MoveMeBaby(float hor, float ver)
    {

        transform.position = new Vector3(transform.position.x + hor, transform.position.y + ver, transform.position.z);
    }
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
        ((Camera)GetComponent("Camera")).orthographicSize = Mathf.Lerp(oldSize, oldSize+ scroll*20,Time.deltaTime);
    }
}