using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
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
        bedRoomMap[0][0] = new Tile(new bool[4] { true, true, false, false },null,null,null,"woodVert",0,0);
        bedRoomMap[0][1] = new Tile(new bool[4] { true, false, false, false },new bool[4] { true, false, false, false }, null, null, "woodVert", 0, 1);
        bedRoomMap[0][2] = new Tile(new bool[4] { true, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 0, 2);
        bedRoomMap[0][3] = new Tile(new bool[4] { true, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 0, 3);
        bedRoomMap[0][4] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "woodVert", 0, 4);
        bedRoomMap[0][5] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "woodVert", 0, 5);
        bedRoomMap[0][6] = new Tile(new bool[4] { true, false, false, true }, null, null, null, "woodVert", 0, 6);


        bedRoomMap[1] = new Tile[7];
        bedRoomMap[1][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "woodVert", 1, 0);
        bedRoomMap[1][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 1, 1);
        bedRoomMap[1][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 1, 2);
        bedRoomMap[1][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 1, 3);
        bedRoomMap[1][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 1, 4);
        bedRoomMap[1][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 1, 5);
        bedRoomMap[1][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "woodVert", 1, 6);

        bedRoomMap[2] = new Tile[7];
        bedRoomMap[2][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "woodVert", 2, 0);
        bedRoomMap[2][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 2, 1);
        bedRoomMap[2][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 2, 2);
        bedRoomMap[2][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 2, 3);
        bedRoomMap[2][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 2, 4);
        bedRoomMap[2][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 2, 5);
        bedRoomMap[2][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "woodVert", 2, 6);

        bedRoomMap[3] = new Tile[7];
        bedRoomMap[3][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "woodVert", 3, 0);
        bedRoomMap[3][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 3, 1);
        bedRoomMap[3][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 3, 2);
        bedRoomMap[3][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 3, 3);
        bedRoomMap[3][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 3, 4);
        bedRoomMap[3][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 3, 5);
        bedRoomMap[3][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "woodVert", 3, 6);

        bedRoomMap[4] = new Tile[7];
        bedRoomMap[4][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "woodVert", 4, 0);
        bedRoomMap[4][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 4, 1);
        bedRoomMap[4][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 4, 2);
        bedRoomMap[4][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 4, 3);
        bedRoomMap[4][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 4, 4);
        bedRoomMap[4][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 4, 5);
        bedRoomMap[4][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "woodVert", 4, 6);

        bedRoomMap[5] = new Tile[7];
        bedRoomMap[5][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "woodVert", 5, 0);
        bedRoomMap[5][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 5, 1);
        bedRoomMap[5][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 5, 2);
        bedRoomMap[5][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 5, 3);
        bedRoomMap[5][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 5, 4);
        bedRoomMap[5][5] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "woodVert", 5, 5);
        bedRoomMap[5][6] = new Tile(new bool[4] { false, false, true, true }, null, null, null, "woodVert", 5, 6);

        bedRoomMap[6] = new Tile[7];
        bedRoomMap[6][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "woodVert", 6, 0);
        bedRoomMap[6][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 6, 1);
        bedRoomMap[6][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 6, 2);
        bedRoomMap[6][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 6, 3);
        bedRoomMap[6][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 6, 4);
        bedRoomMap[6][5] = new Tile(new bool[4] { true, false, false, false }, null, null, null, "woodVert", 6, 5);
        bedRoomMap[6][6] = new Tile(new bool[4] { true, false, false, true }, null, null, null, "woodVert", 6, 6);

        bedRoomMap[7] = new Tile[7];
        bedRoomMap[7][0] = new Tile(new bool[4] { false, true, false, false }, null, null, null, "woodVert", 7, 0);
        bedRoomMap[7][1] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 7, 1);
        bedRoomMap[7][2] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 7, 2);
        bedRoomMap[7][3] = new Tile(new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 7, 3);
        bedRoomMap[7][4] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 7, 4);
        bedRoomMap[7][5] = new Tile(new bool[4] { false, false, false, false }, null, null, null, "woodVert", 7, 5);
        bedRoomMap[7][6] = new Tile(new bool[4] { false, false, false, true }, null, null, null, "woodVert", 7, 6);


        bedRoomMap[8] = new Tile[7];
        bedRoomMap[8][0] = new Tile(new bool[4] { false, true, true, false }, null, null, null, "woodVert", 8, 0);
        bedRoomMap[8][1] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "woodVert", 8, 1);
        bedRoomMap[8][2] = new Tile(new bool[4] { false, false, true, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 8, 2);
        bedRoomMap[8][3] = new Tile(new bool[4] { false, false, true, false }, new bool[4] { true, false, false, false }, null, null, "woodVert", 8, 3);
        bedRoomMap[8][4] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "woodVert", 8, 4);
        bedRoomMap[8][5] = new Tile(new bool[4] { false, false, true, false }, null, null, null, "woodVert", 8, 5);
        bedRoomMap[8][6] = new Tile(new bool[4] { false, false, true, false }, null,new bool[4] { false, false, false, true } , new bool[4] { false, false, false, true }, "woodVert", 8, 6);

    } 


    public void DrawRoom(Room room)
    {

    }

}
