using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Site
{
    public readonly int width;
    public readonly int height;
    
    public Room[] rooms;

    public Site(Room[] rooms, int w, int h)
    {
        this.rooms = rooms;
        width = w;
        height = h;
    }
}
