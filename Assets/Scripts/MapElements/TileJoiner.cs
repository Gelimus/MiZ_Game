using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileJoiner 
{
    readonly bool hasWall;
    readonly bool hasWindow;
    readonly bool hasDoorway;

    Doorway doorwayComponent;



    public TileJoiner(bool wall, bool window, bool doorway=false,bool doorwayHasDoor=false)
    {
        hasWall = wall;
        hasWindow = window;
        hasDoorway = doorway;
        if (hasDoorway)
        {
            doorwayComponent = new Doorway(doorwayHasDoor);
        }
    }
}
