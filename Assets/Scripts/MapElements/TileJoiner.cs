using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileJoiner 
{
    public readonly bool hasWall;
    public readonly bool hasWindow;
    public readonly bool hasDoorway;

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
