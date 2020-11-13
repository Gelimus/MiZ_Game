using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Site
{
    public readonly int width;
    public readonly int height;
    
    public Room[] rooms;
    public Tile[,] map;

    public Site(Room[] rooms,Tile[,] map, int w, int h)
    {
        this.rooms = rooms;
        this.map = map;
        width = w;
        height = h;
    }
}
