using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile 
{

    public readonly int yCoord;
    public readonly int xCoord;


    public readonly string floorType;

    public readonly TileJoiner north;
    public readonly TileJoiner west;
    public readonly TileJoiner south;
    public readonly TileJoiner east;



    private Doorway doorComponent;

    int passageCost;

    public Tile(bool[] walls, bool[] windows ,bool[] doors,bool[] doorwayHasDoors, string fT, int x, int y)
    {
        if (walls == null)
        {
            walls = new bool[4] { false, false, false, false };
        }
        if (windows == null)
        {
            windows = new bool[4] { false, false, false, false };
        }
        if (doors == null)
        {
            doors = new bool[4] { false, false, false, false };
        }
        if (doorwayHasDoors == null)
        {
            doors = new bool[4] { false, false, false, false };
        }


        if ((walls.Length != 4) || windows.Length != 4)
        {
            Debug.LogError("Incorrect tile values passed to constructor!!!");
            return;
        }
        north = new TileJoiner(walls[0], windows[0],doors[0]);
        west = new TileJoiner(walls[1], windows[1],doors[1]);
        south = new TileJoiner(walls[2], windows[2], doors[2]);
        east = new TileJoiner(walls[3], windows[3], doors[3]);
        floorType = fT;
        xCoord = x;
        yCoord = y;
    }


    

}
