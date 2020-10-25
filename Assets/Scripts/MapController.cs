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
        bedRoomMap[0][0] = new Tile(new bool[4] { true, true, false, false },null,null,null,"wood1",0,0);
        bedRoomMap[0][1] = new Tile(new bool[4] { false, false, false, false },new bool[4] { true, false, false, false }, null, null, "wood1", 0, 1);
        bedRoomMap[0][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood1", 0, 2);
        bedRoomMap[0][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood1", 0, 3);
        bedRoomMap[0][4] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "wood1", 0, 4);
        bedRoomMap[0][5] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "wood1", 0, 5);
        bedRoomMap[0][6] = new Tile(new bool[4] { true, false, false, true }, null, null, null, "wood1", 0, 6);


        bedRoomMap[1] = new Tile[7];
        bedRoomMap[1][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood1", -1, 0);
        bedRoomMap[1][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 1);
        bedRoomMap[1][2] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 2);
        bedRoomMap[1][3] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 3);
        bedRoomMap[1][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 4);
        bedRoomMap[1][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 5);
        bedRoomMap[1][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood1", -1, 6);

        bedRoomMap[2] = new Tile[7];
        bedRoomMap[2][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood1", -2, 0);
        bedRoomMap[2][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 1);
        bedRoomMap[2][2] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 2);
        bedRoomMap[2][3] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 3);
        bedRoomMap[2][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 4);
        bedRoomMap[2][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 5);
        bedRoomMap[2][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood1", -2, 6);

        bedRoomMap[3] = new Tile[7];
        bedRoomMap[3][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood1", -3, 0);
        bedRoomMap[3][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 1);
        bedRoomMap[3][2] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 2);
        bedRoomMap[3][3] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 3);
        bedRoomMap[3][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 4);
        bedRoomMap[3][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 5);
        bedRoomMap[3][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood1", -3, 6);

        bedRoomMap[4] = new Tile[7];
        bedRoomMap[4][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood1", -4, 0);
        bedRoomMap[4][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 1);
        bedRoomMap[4][2] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 2);
        bedRoomMap[4][3] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 3);
        bedRoomMap[4][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 4);
        bedRoomMap[4][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 5);
        bedRoomMap[4][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood1", -4, 6);

        bedRoomMap[5] = new Tile[7];
        bedRoomMap[5][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood1", -5, 0);
        bedRoomMap[5][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 1);
        bedRoomMap[5][2] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 2);
        bedRoomMap[5][3] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 3);
        bedRoomMap[5][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 4);
        bedRoomMap[5][5] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood1", -5, 5);
        bedRoomMap[5][6] = new Tile(new bool[4] { false, false, true, true }, null, null, null, "wood1", -5, 6);

        bedRoomMap[6] = new Tile[7];
        bedRoomMap[6][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood1", -6, 0);
        bedRoomMap[6][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 1);
        bedRoomMap[6][2] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 2);
        bedRoomMap[6][3] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 3);
        bedRoomMap[6][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 4);
        bedRoomMap[6][5] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "wood1", -6, 5);
        bedRoomMap[6][6] = new Tile(new bool[4] { true, false, false, true }, null, null, null, "wood1", -6, 6);

        bedRoomMap[7] = new Tile[7];
        bedRoomMap[7][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "wood1", -7, 0);
        bedRoomMap[7][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 1);
        bedRoomMap[7][2] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 2);
        bedRoomMap[7][3] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 3);
        bedRoomMap[7][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 4);
        bedRoomMap[7][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 5);
        bedRoomMap[7][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "wood1", -7, 6);


        bedRoomMap[8] = new Tile[7];
        bedRoomMap[8][0] = new Tile(new bool[4] { false, true, true, false }, null, null, null, "wood1", -8, 0);
        bedRoomMap[8][1] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 1);
        bedRoomMap[8][2] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 2);
        bedRoomMap[8][3] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 3);
        bedRoomMap[8][4] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 4);
        bedRoomMap[8][5] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 5);
        bedRoomMap[8][6] = new Tile(new bool[4] { false, false, true, false }, null,new bool[4] { false, false, false, true } , new bool[4] { false, false, false, true }, "wood1", -8, 6);


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
        GameObject wallsVisuals = GenerateWallsVisuals(tile);
        if (wallsVisuals != null)
        {
            wallsVisuals.transform.SetParent(tileVisuals.transform);
            wallsVisuals.transform.localPosition = Vector3.zero;
        }
        //GameObject windowsVisuals = GenerateWindowsVisuals(tile);
        GameObject floorVisuals = GenerateFloorVisuals(tile);
        floorVisuals.transform.SetParent(tileVisuals.transform);
        floorVisuals.transform.localPosition = Vector3.zero;

        return tileVisuals;
    }

    //private GameObject GenerateWallsVisuals(Tile tile)
    //{

    //    //Check what walls if any surround the tile.
    //    string wallTextureName = "";
    //    if (tile.north.hasWall)
    //    {
    //        wallTextureName += "N";
    //    }
    //    if (tile.west.hasWall)
    //    {
    //        wallTextureName += "W";
    //    }
    //    if (tile.south.hasWall)
    //    {
    //        wallTextureName += "S";
    //    }
    //    if (tile.east.hasWall)
    //    {
    //        wallTextureName += "E";
    //    }
    //    //If no walls are present exit the function with a null value
    //    if (wallTextureName == "")
    //    {
    //        return null;
    //    }
    //    //Create a GameObject with a Sprite Renderer component
    //    GameObject wallsVisuals = new GameObject("Walls");
    //    SpriteRenderer sr = wallsVisuals.AddComponent<SpriteRenderer>();

    //    //Load a texture and create a sprite from it, and apply said sprite to the Sprite Renderer component.
    //    Texture2D tex = Resources.Load<Texture2D>("Sprites/TileWalls/" + wallTextureName);
    //    sr.sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), tileScale);
    //    sr.sortingLayerName = "Walls";


    //    return wallsVisuals;
    //}

    private GameObject GenerateWallsVisuals(Tile tile)
    {

        //Check what walls if any surround the tile.
        Texture2D tex = null;

        if (tile.north.hasWall)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord +" generated North wall as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/N");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated North wall as its further.");

                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/N"));
            }
        }
        else if (tile.north.hasWindow)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated North window as its first.");

                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowN");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated North window as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/windowN"),true);
            }
        }
        if (tile.west.hasWall)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West wall as its first.");

                tex = Resources.Load<Texture2D>("Sprites/TileWalls/W");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West wall as its further.");

                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/W"));
            }
        }
        else if (tile.west.hasWindow)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West window as its first.");

                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowW");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West window as its further.");

                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/windowW"), true);
            }
        }
        if (tile.south.hasWall)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South wall as its first.");

                tex = Resources.Load<Texture2D>("Sprites/TileWalls/S");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South wall as its further.");

                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/S"));
            }
        }
        else if (tile.south.hasWindow)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South window as its first.");

                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowS");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South window as its further.");

                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/windowS"), true);
            }
        }
        if (tile.east.hasWall)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East wall as its first.");

                tex = Resources.Load<Texture2D>("Sprites/TileWalls/E");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East wall as its further.");

                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/E"));
            }
        }
        else if (tile.east.hasWindow)
        {
            if (tex == null)
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East window as its first.");

                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowE");
            }
            else
            {
                Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East window as its further.");

                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/windowE"), true);
            }
        }
        //If no walls are present exit the function with a null value
        if (tex == null)
        {
            return null;
        }
        //Create a GameObject with a Sprite Renderer component
        GameObject wallsVisuals = new GameObject("Walls");
        SpriteRenderer sr = wallsVisuals.AddComponent<SpriteRenderer>();

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
        int floorSprite = Random.Range(0, 6);
        Texture2D tex = Resources.Load<Texture2D>("Sprites/TileFloors/" + tile.floorType+floorSprite);
        sr.sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f,0.5f), tileScale);
        sr.sortingLayerName = "Floors";
        //int floorRotation = Random.Range(0, 2);
        //floorVisuals.transform.rotation = Quaternion.AngleAxis(floorRotation * 180f, new Vector3(0, 0, 1));

        return floorVisuals;
    }


    //private GameObject GenerateWindowsVisuals(Tile tile)
    //{
    //    GameObject windowsVisuals = new GameObject("Windows");
    //    SpriteRenderer sr = floorVisuals.AddComponent<SpriteRenderer>();
    //    Texture2D winText=null;
        
    //    if (tile.north.hasWall)
    //    {
    //        if (winText==null)
    //        {
    //            winText= Resources.Load<Texture2D>("Sprites/TileWalls/windowN");
    //        }
    //        else
    //        {
    //            winText = MergeTextures(winText, Resources.Load<Texture2D>("Sprites/TileWalls/windowN"));
    //        }
    //    }
    //    if (tile.west.hasWall)
    //    {
    //        if (winText == null)
    //        {
    //            winText = Resources.Load<Texture2D>("Sprites/TileWalls/windowW");
    //        }
    //        else
    //        {
    //            winText = MergeTextures(winText, Resources.Load<Texture2D>("Sprites/TileWalls/windowW"));
    //        }
    //    }
    //    if (tile.south.hasWall)
    //    {
    //        if (winText == null)
    //        {
    //            winText = Resources.Load<Texture2D>("Sprites/TileWalls/windowW");
    //        }
    //        else
    //        {
    //            winText = MergeTextures(winText, Resources.Load<Texture2D>("Sprites/TileWalls/windowW"));
    //        }
    //    }
    //    if (tile.east.hasWall)
    //    {
    //        if (winText == null)
    //        {
    //            winText = Resources.Load<Texture2D>("Sprites/TileWalls/windowW");
    //        }
    //        else
    //        {
    //            winText = MergeTextures(winText, Resources.Load<Texture2D>("Sprites/TileWalls/windowW"));
    //        }
    //    }


    //    return windowsVisuals;
    //}

    private Texture2D MergeTextures(Texture2D first,Texture2D second,bool firstOverridesSecond=false)
    {
        Texture2D final = new Texture2D(first.width, first.height);
        for (int x = 0; x < first.width; x++)
        {
            for (int y = 0; y < first.height; y++)
            {
                Color firstColor = first.GetPixel(x, y);             
                Color secondColor = second.GetPixel(x, y);
                Color finalColor = new Color();
                if (secondColor.a < 0.5)
                {
                    finalColor = firstColor;
                }else if (firstColor.a < 0.5)
                {
                    finalColor = secondColor;
                }
                else
                {
                    if (firstOverridesSecond)
                    {
                        finalColor = firstColor;
                    }
                    else
                    {
                        finalColor = Color.Lerp(firstColor, secondColor, firstColor.a / 1.0f);
                    }
                    
                }
                final.SetPixel(x, y, finalColor);
            }
        }
        final.Apply();
        return final;

    }
}
