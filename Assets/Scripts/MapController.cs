using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    private float tileScale = 64f;

    // Start is called before the first frame update
    void Start()
    {
        GenerateTestSite();
    }

    // Update is called once per frame
    void Update()
    {

    }



    
    private void GenerateTestSite()
    {
        Tile[][] bedRoomMap = new Tile[9][];

        bedRoomMap[0] = new Tile[7];
        bedRoomMap[0][0] = new Tile(new bool[4] { true, true, false, false },null,null,null,"wood00",0,0);
        bedRoomMap[0][1] = new Tile(new bool[4] { true, false, false, false },new bool[4] { true, false, false, false }, null, null, "wood00", 0, 1);
        bedRoomMap[0][2] = new Tile(new bool[4] { true, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", 0, 2);
        bedRoomMap[0][3] = new Tile(new bool[4] { true, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", 0, 3);
        bedRoomMap[0][4] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "wood00", 0, 4);
        bedRoomMap[0][5] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "wood00", 0, 5);
        bedRoomMap[0][6] = new Tile(new bool[4] { true, false, false, true }, null, null, null, "wood00", 0, 6);


        bedRoomMap[1] = new Tile[7];
        bedRoomMap[1][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood00", -1, 0);
        bedRoomMap[1][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -1, 1);
        bedRoomMap[1][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -1, 2);
        bedRoomMap[1][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -1, 3);
        bedRoomMap[1][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -1, 4);
        bedRoomMap[1][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -1, 5);
        bedRoomMap[1][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood00", -1, 6);

        bedRoomMap[2] = new Tile[7];
        bedRoomMap[2][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood00", -2, 0);
        bedRoomMap[2][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -2, 1);
        bedRoomMap[2][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -2, 2);
        bedRoomMap[2][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -2, 3);
        bedRoomMap[2][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -2, 4);
        bedRoomMap[2][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -2, 5);
        bedRoomMap[2][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood00", -2, 6);

        bedRoomMap[3] = new Tile[7];
        bedRoomMap[3][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood00", -3, 0);
        bedRoomMap[3][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -3, 1);
        bedRoomMap[3][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -3, 2);
        bedRoomMap[3][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -3, 3);
        bedRoomMap[3][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -3, 4);
        bedRoomMap[3][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -3, 5);
        bedRoomMap[3][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood00", -3, 6);

        bedRoomMap[4] = new Tile[7];
        bedRoomMap[4][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood00", -4, 0);
        bedRoomMap[4][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -4, 1);
        bedRoomMap[4][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -4, 2);
        bedRoomMap[4][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -4, 3);
        bedRoomMap[4][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -4, 4);
        bedRoomMap[4][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -4, 5);
        bedRoomMap[4][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood00", -4, 6);

        bedRoomMap[5] = new Tile[7];
        bedRoomMap[5][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood00", -5, 0);
        bedRoomMap[5][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -5, 1);
        bedRoomMap[5][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -5, 2);
        bedRoomMap[5][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -5, 3);
        bedRoomMap[5][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -5, 4);
        bedRoomMap[5][5] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood00", -5, 5);
        bedRoomMap[5][6] = new Tile(new bool[4] { false, false, true, true }, null, null, null, "wood00", -5, 6);

        bedRoomMap[6] = new Tile[7];
        bedRoomMap[6][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood00", -6, 0);
        bedRoomMap[6][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -6, 1);
        bedRoomMap[6][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -6, 2);
        bedRoomMap[6][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -6, 3);
        bedRoomMap[6][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -6, 4);
        bedRoomMap[6][5] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "wood00", -6, 5);
        bedRoomMap[6][6] = new Tile(new bool[4] { true, false, false, true }, null, null, null, "wood00", -6, 6);

        bedRoomMap[7] = new Tile[7];
        bedRoomMap[7][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood00", -7, 0);
        bedRoomMap[7][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -7, 1);
        bedRoomMap[7][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -7, 2);
        bedRoomMap[7][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -7, 3);
        bedRoomMap[7][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -7, 4);
        bedRoomMap[7][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood00", -7, 5);
        bedRoomMap[7][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood00", -7, 6);


        bedRoomMap[8] = new Tile[7];
        bedRoomMap[8][0] = new Tile(new bool[4] { false, true, true, false }, null, null, null, "wood00", -8, 0);
        bedRoomMap[8][1] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood00", -8, 1);
        bedRoomMap[8][2] = new Tile(new bool[4] { false, false, true, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -8, 2);
        bedRoomMap[8][3] = new Tile(new bool[4] { false, false, true, false }, new bool[4] { true, false, false, false }, null, null, "wood00", -8, 3);
        bedRoomMap[8][4] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood00", -8, 4);
        bedRoomMap[8][5] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood00", -8, 5);
        bedRoomMap[8][6] = new Tile(new bool[4] { false, false, true, false }, null,new bool[4] { false, false, false, true } , new bool[4] { false, false, false, true }, "wood00", -8, 6);


        Room bedroom = new Room(bedRoomMap);
        Site testMap = new Site(new Room[]{ bedroom },7,9);
        
        DrawMap(testMap);

    } 

    public void DrawMap(Site site)
    {
        GameObject mapHolder = new GameObject("MapHolder");
        GameObject mask = new GameObject("NoiseMask");
        mask.transform.SetParent(mapHolder.transform);
        mask.AddComponent<SpriteRenderer>();
        MapNoise noiseGen = mask.AddComponent<MapNoise>();
        
        foreach (Room r in site.rooms)
        {
            DrawRoom(r, mapHolder);
        }

        noiseGen.LetThereBeNoise(site.width*(int)tileScale, site.height*(int)tileScale, tileScale);
    }

    public void DrawRoom(Room room, GameObject mapHolder)
    {
        for (int i = 0; i < room.map.Length; i++)
        {
            for (int j = 0; j < room.map[i].Length; j++)
            {
                GameObject tile = GenerateTileVisual(room.map[i][j]);
                tile.transform.SetParent(mapHolder.transform);
            }
        }
    }
    private GameObject GenerateTileVisual(Tile tile)
    {
        //Generate parent GameObject
        GameObject tileVisuals = new GameObject(tile.yCoord + " x " + tile.xCoord);
        tileVisuals.transform.position = new Vector3(tile.yCoord, tile.xCoord);

        //Call a function to generate a game object with walls visuals and add it to the parent (if there are any walls)
        GameObject wallsVisuals = GenerateWallVisuals(tile);
        if (wallsVisuals != null)
        {
            wallsVisuals.transform.SetParent(tileVisuals.transform);
            wallsVisuals.transform.localPosition = Vector3.zero;
        }

        GameObject floorVisuals = GenerateFloorVisuals(tile);
        floorVisuals.transform.SetParent(tileVisuals.transform);
        floorVisuals.transform.localPosition = Vector3.zero;

        return tileVisuals;
    }

    private GameObject GenerateWallVisuals(Tile tile)
    {
       
        //Check what walls if any surround the tile.
        string wallTextureName = "";
        if (tile.north.hasWall)
        {
            wallTextureName += "N";
        }
        if (tile.west.hasWall)
        {
            wallTextureName += "W";
        }
        if (tile.south.hasWall)
        {
            wallTextureName += "S";
        }
        if (tile.east.hasWall)
        {
            wallTextureName += "E";
        }
        //If no walls are present exit the function with a null value
        if (wallTextureName == "")
        {
            return null;
        }
        //Create a GameObject with a Sprite Renderer component
        GameObject wallsVisuals = new GameObject("Walls");
        SpriteRenderer sr = wallsVisuals.AddComponent<SpriteRenderer>();

        //Load a texture and create a sprite from it, and apply said sprite to the Sprite Renderer component.
        Texture2D tex = Resources.Load<Texture2D>("Sprites/TileWalls/" + wallTextureName);
        sr.sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), tileScale);
        sr.sortingLayerName = "Walls";


        return wallsVisuals;
    }

    private GameObject GenerateFloorVisuals(Tile tile)
    {
        //Create a GameObject with a Sprite Renderer component
        GameObject floorVisuals = new GameObject("Floor " + tile.floorType);
        
        SpriteRenderer sr = floorVisuals.AddComponent<SpriteRenderer>();

        //Load a texture and create a sprite from it, and apply said sprite to the Sprite Renderer component.
        Texture2D tex = Resources.Load<Texture2D>("Sprites/TileFloors/" + tile.floorType);
        sr.sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f,0.5f), tileScale);
        sr.sortingLayerName = "Floors";
        //int floorRotation = Random.Range(0, 2);
        //floorVisuals.transform.rotation = Quaternion.AngleAxis(floorRotation * 180f, new Vector3(0, 0, 1));

        return floorVisuals;
    }

}
