using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    private float tileScale = 64f;

    public Site activeSite
    {
        get;
        private set;
    }

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
        List<FurnitureAction> actions = new List<FurnitureAction>
        {
            new SearchAction()
        };
        FurnitureType doublebed = new FurnitureType("doublebed", "Double Bed", new Vector2(3, 4), actions);
        Furniture bed = new Furniture("Double Bed 1",doublebed,new Vector2(0,-1),Quaternion.Euler(0,0,90));

        FurnitureType nightstand = new FurnitureType("nightstand", "Night Stand", new Vector2(1, 1), actions);
        Furniture nightStand1 = new Furniture("Night Stand 1", nightstand, new Vector2(0, 0), Quaternion.identity);
        Furniture nightStand2 = new Furniture("Night Stand 2", nightstand, new Vector2(0, -4), Quaternion.identity);

        FurnitureType wardrobe = new FurnitureType("wardrobe", "Wardrobe", new Vector2(2, 1), actions);
        Furniture wardrobe1 = new Furniture("Wardrobe 1", wardrobe, new Vector2(6, 0), Quaternion.Euler(0, 0, -90));
        Furniture wardrobe2 = new Furniture("Wardrobe 2", wardrobe, new Vector2(0, -6), Quaternion.Euler(0, 0, 90));
        Furniture wardrobe3 = new Furniture("Wardrobe 3", wardrobe, new Vector2(5, -6), Quaternion.identity);

        FurnitureType carpet = new FurnitureType("carpet", "Carpet", new Vector2(2, 2), actions);
        Furniture carpet1 = new Furniture("Carpet 1", carpet, new Vector2(2, -5), Quaternion.identity);

        FurnitureType desk = new FurnitureType("desk", "Desk", new Vector2(3, 1), actions);
        Furniture desk1 = new Furniture("Desk 1", desk, new Vector2(6, -3), Quaternion.Euler(0, 0, -90));

        FurnitureType chair = new FurnitureType("chair", "Chair", new Vector2(1, 2), actions);
        Furniture chair1 = new Furniture("Chair 1", chair, new Vector2(5, -4), Quaternion.Euler(0, 0, 90));

        List<Furniture> bedroomFurniture = new List<Furniture>
        {
            bed, nightStand1, nightStand2,wardrobe1,wardrobe2,wardrobe3,carpet1,desk1,chair1
        };
        Room bedroom = new Room(bedroomFurniture,"Bedroom");

        Room bathroom = new Room(new List<Furniture>(), "Bathroom");
        Room balcony = new Room(new List<Furniture>(), "Balcony");
        Room kitchen = new Room(new List<Furniture>(), "Kitchen");
        Room livingRoom = new Room(new List<Furniture>(), "Living Room");
        Room hall = new Room(new List<Furniture>(), "Hall");

        Tile[,] testSiteMap = new Tile[12,16];

        
        testSiteMap[0,0] = new Tile(bedroom, new bool[4] { true, true, false, false },null,null,null,"wood1",0,0);
        testSiteMap[0,1] = new Tile(bedroom, new bool[4] { false, false, false, false },new bool[4] { true, false, false, false }, null, null, "wood1", 0, 1);
        testSiteMap[0,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood1", 0, 2);
        testSiteMap[0,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, new bool[4] { true, false, false, false }, null, null, "wood1", 0, 3);
        testSiteMap[0,4] = new Tile(bedroom, new bool[4] { true, false, false, false }, null, null, null, "wood1", 0, 4);
        testSiteMap[0,5] = new Tile(bedroom, new bool[4] { true, false, false, false }, null, null, null, "wood1", 0, 5);
        testSiteMap[0,6] = new Tile(bedroom, new bool[4] { true, false, false, true }, null, null, null, "wood1", 0, 6);
        //---------------------------
        testSiteMap[0, 7] = new Tile(balcony, new bool[4] { false, true, false, false }, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 7);
        testSiteMap[0, 8] = new Tile(balcony, null, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 8);
        testSiteMap[0, 9] = new Tile(balcony, null, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 9);
        testSiteMap[0, 10] = new Tile(balcony, null, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 10);
        testSiteMap[0, 11] = new Tile(balcony, null, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 11);
        testSiteMap[0, 12] = new Tile(balcony, null, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 12);
        testSiteMap[0, 13] = new Tile(balcony, null, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 13);
        testSiteMap[0, 14] = new Tile(balcony, null, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 14);
        testSiteMap[0, 15] = new Tile(balcony, new bool[4] { false, false, false, true }, new bool[4] { true, false, false, false }, null, null, "carpet01", 0, 15);

        //---------------------------------------------------------------

        testSiteMap[1,0] = new Tile(bedroom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -1, 0);
        testSiteMap[1,1] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 1);
        testSiteMap[1,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 2);
        testSiteMap[1,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 3);
        testSiteMap[1,4] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 4);
        testSiteMap[1,5] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -1, 5);
        testSiteMap[1,6] = new Tile(bedroom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -1, 6);
        //---------------------------
        testSiteMap[1, 7] = new Tile(balcony, new bool[4] { false, true, true, false }, null, null, null, "carpet01", -1, 7);
        testSiteMap[1, 8] = new Tile(balcony, null, null, null, null, "carpet01", -1, 8);
        testSiteMap[1, 9] = new Tile(balcony, null, null, null, null, "carpet01", -1, 9);
        testSiteMap[1, 10] = new Tile(balcony, new bool[4] { false, false, true, false }, null, null, null, "carpet01", -1, 10);
        testSiteMap[1, 11] = new Tile(balcony, new bool[4] { false, false, true, false }, null, null, null, "carpet01", -1, 11);
        testSiteMap[1, 12] = new Tile(balcony, new bool[4] { false, false, true, false }, null, null, null, "carpet01", -1, 12);
        testSiteMap[1, 13] = new Tile(balcony, null, null, new bool[4] { false, false, true, false }, new bool[4] { false, false, true, false }, "carpet01", -1, 13);
        testSiteMap[1, 14] = new Tile(balcony, null, null, new bool[4] { false, false, true, false }, new bool[4] { false, false, true, false }, "carpet01", -1, 14);
        testSiteMap[1, 15] = new Tile(balcony, new bool[4] { false, false, true, true }, null, null, null, "carpet01", -1, 15);

        //---------------------------------------------------------------

        testSiteMap[2,0] = new Tile(bedroom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -2, 0);
        testSiteMap[2,1] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 1);
        testSiteMap[2,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 2);
        testSiteMap[2,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 3);
        testSiteMap[2,4] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 4);
        testSiteMap[2,5] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -2, 5);
        testSiteMap[2,6] = new Tile(bedroom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -2, 6);
        //---------------------------
        testSiteMap[2, 7] = new Tile(kitchen, new bool[4] { true, true, false, false },null , null, null, "tiles01", -2, 7);
        testSiteMap[2, 8] = new Tile(kitchen, null, new bool[4] { true, false, false, false }, null, null, "tiles01", -2, 8);
        testSiteMap[2, 9] = new Tile(kitchen, null, new bool[4] { true, false, false, false }, null, null, "tiles01", -2, 9);
        testSiteMap[2, 10] = new Tile(kitchen, new bool[4] { true, false, false, true }, null, null, null, "tiles01", -2, 10);
        //---------------------------
        testSiteMap[2, 11] = new Tile(livingRoom, new bool[4] { true, true, false, false }, null, null, null, "wood1", -2, 11);
        testSiteMap[2, 12] = new Tile(livingRoom, new bool[4] { true, false, false, false }, null, null, null, "wood1", -2, 12);
        testSiteMap[2, 13] = new Tile(livingRoom, null, null, new bool[4] { true, false, false, false }, new bool[4] { true, false, false, false }, "wood1", -2, 13);
        testSiteMap[2, 14] = new Tile(livingRoom, null, null, new bool[4] { true, false, false, false }, new bool[4] { true, false, false, false }, "wood1", -2, 14);
        testSiteMap[2, 15] = new Tile(livingRoom, new bool[4] { true, false, false, true }, null, null, null, "wood1", -2, 15);

        //---------------------------------------------------------------

        testSiteMap[3,0] = new Tile(bedroom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -3, 0);
        testSiteMap[3,1] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 1);
        testSiteMap[3,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 2);
        testSiteMap[3,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 3);
        testSiteMap[3,4] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 4);
        testSiteMap[3,5] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -3, 5);
        testSiteMap[3,6] = new Tile(bedroom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -3, 6);
        //---------------------------
        testSiteMap[3, 7] = new Tile(kitchen, new bool[4] { false, true, false, false }, null, null, null, "tiles01", -3, 7);
        testSiteMap[3, 8] = new Tile(kitchen, null, null, null, null, "tiles01", -3, 8);
        testSiteMap[3, 9] = new Tile(kitchen, null, null, null, null, "tiles01", -3, 9);
        testSiteMap[3, 10] = new Tile(kitchen, new bool[4] { false, false, false, true }, null, null, null, "tiles01", -3, 10);
        //---------------------------
        testSiteMap[3, 11] = new Tile(livingRoom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -3, 11);
        testSiteMap[3, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -3, 12);
        testSiteMap[3, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -3, 13);
        testSiteMap[3, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -3, 14);
        testSiteMap[3, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -3, 15);

        //---------------------------------------------------------------

        testSiteMap[4,0] = new Tile(bedroom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -4, 0);
        testSiteMap[4,1] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 1);
        testSiteMap[4,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 2);
        testSiteMap[4,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 3);
        testSiteMap[4,4] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 4);
        testSiteMap[4,5] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -4, 5);
        testSiteMap[4,6] = new Tile(bedroom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -4, 6);
        //---------------------------
        testSiteMap[4, 7] = new Tile(kitchen, new bool[4] { false, true, false, false }, null, null, null, "tiles01", -4, 7);
        testSiteMap[4, 8] = new Tile(kitchen, null, null, null, null, "tiles01", -4, 8);
        testSiteMap[4, 9] = new Tile(kitchen, null, null, null, null, "tiles01", -4, 9);
        testSiteMap[4, 10] = new Tile(kitchen, new bool[4] { false, false, false, true }, null, null, null, "tiles01", -4, 10);
        //---------------------------
        testSiteMap[4, 11] = new Tile(livingRoom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -4, 11);
        testSiteMap[4, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -4, 12);
        testSiteMap[4, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -4, 13);
        testSiteMap[4, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -4, 14);
        testSiteMap[4, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -4, 15);

        //---------------------------------------------------------------

        testSiteMap[5,0] = new Tile(bedroom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -5, 0);
        testSiteMap[5,1] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 1);
        testSiteMap[5,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 2);
        testSiteMap[5,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 3);
        testSiteMap[5,4] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -5, 4);
        testSiteMap[5,5] = new Tile(bedroom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -5, 5);
        testSiteMap[5,6] = new Tile(bedroom, new bool[4] { false, false, true, true }, null, null, null, "wood1", -5, 6);
        //---------------------------
        testSiteMap[5, 7] = new Tile(kitchen, new bool[4] { false, true, false, false }, null, null, null, "tiles01", -5, 7);
        testSiteMap[5, 8] = new Tile(kitchen, null, null, null, null, "tiles01", -5, 8);
        testSiteMap[5, 9] = new Tile(kitchen, null, null, null, null, "tiles01", -5, 9);
        testSiteMap[5, 10] = new Tile(kitchen, new bool[4] { false, false, false, true }, null, null, null, "tiles01", -5, 10);
        //---------------------------
        testSiteMap[5, 11] = new Tile(livingRoom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -5, 11);
        testSiteMap[5, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -5, 12);
        testSiteMap[5, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -5, 13);
        testSiteMap[5, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -5, 14);
        testSiteMap[5, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -5, 15);

        //---------------------------------------------------------------

        testSiteMap[6,0] = new Tile(bedroom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -6, 0);
        testSiteMap[6,1] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 1);
        testSiteMap[6,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 2);
        testSiteMap[6,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 3);
        testSiteMap[6,4] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -6, 4);
        testSiteMap[6,5] = new Tile(bedroom, new bool[4] { true, false, false, false }, null, null, null, "wood1", -6, 5);
        testSiteMap[6,6] = new Tile(bedroom, new bool[4] { true, false, false, true }, null, null, null, "wood1", -6, 6);
        //---------------------------
        testSiteMap[6, 7] = new Tile(kitchen, new bool[4] { false, true, false, false }, null, null, null, "tiles01", -6, 7);
        testSiteMap[6, 8] = new Tile(kitchen, null, null, null, null, "tiles01", -6, 8);
        testSiteMap[6, 9] = new Tile(kitchen, null, null, null, null, "tiles01", -6, 9);
        testSiteMap[6, 10] = new Tile(kitchen, new bool[4] { false, false, false, true }, null, null, null, "tiles01", -6, 10);
        //---------------------------
        testSiteMap[6, 11] = new Tile(livingRoom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -6, 11);
        testSiteMap[6, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -6, 12);
        testSiteMap[6, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -6, 13);
        testSiteMap[6, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -6, 14);
        testSiteMap[6, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -6, 15);

        //---------------------------------------------------------------

        testSiteMap[7,0] = new Tile(bedroom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -7, 0);
        testSiteMap[7,1] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 1);
        testSiteMap[7,2] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 2);
        testSiteMap[7,3] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 3);
        testSiteMap[7,4] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 4);
        testSiteMap[7,5] = new Tile(bedroom, new bool[4] { false, false, false, false }, null, null, null, "wood1", -7, 5);
        testSiteMap[7,6] = new Tile(bedroom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -7, 6);
        //---------------------------
        testSiteMap[7, 7] = new Tile(kitchen, new bool[4] { false, true, true, false }, null, null, null, "tiles01", -7, 7);
        testSiteMap[7, 8] = new Tile(kitchen, null, null, new bool[4] { false, false, true, false }, null, "tiles01", -7, 8);
        testSiteMap[7, 9] = new Tile(kitchen, new bool[4] { false, false, true, false }, null, null, null, "tiles01", -7, 9);
        testSiteMap[7, 10] = new Tile(kitchen, new bool[4] { false, false, true, true }, null, null, null, "tiles01", -7, 10);
        //---------------------------
        testSiteMap[7, 11] = new Tile(livingRoom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -7, 11);
        testSiteMap[7, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -7, 12);
        testSiteMap[7, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -7, 13);
        testSiteMap[7, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -7, 14);
        testSiteMap[7, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -7, 15);

        //---------------------------------------------------------------

        testSiteMap[8,0] = new Tile(bedroom, new bool[4] { false, true, true, false }, null, null, null, "wood1", -8, 0);
        testSiteMap[8,1] = new Tile(bedroom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 1);
        testSiteMap[8,2] = new Tile(bedroom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 2);
        testSiteMap[8,3] = new Tile(bedroom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 3);
        testSiteMap[8,4] = new Tile(bedroom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 4);
        testSiteMap[8,5] = new Tile(bedroom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -8, 5);
        testSiteMap[8,6] = new Tile(bedroom, new bool[4] { false, false, true, false }, null,new bool[4] { false, false, false, true } , new bool[4] { false, false, false, true }, "wood1", -8, 6);
        //---------------------------
        testSiteMap[8, 7] = new Tile(hall, new bool[4] { true, false, false, false }, null, new bool[4] { false, true, false, false }, new bool[4] { false, true, false, false }, "tiles01", -8, 7);
        testSiteMap[8, 8] = new Tile(hall, null, null, new bool[4] { true, false, false, false }, null, "tiles01", -8, 8);
        testSiteMap[8, 9] = new Tile(hall, new bool[4] { true, false, false, false }, null, null, null, "tiles01", -8, 9);
        testSiteMap[8, 10] = new Tile(hall, new bool[4] { true, false, false, true }, null, null, null, "tiles01", -8, 10);
        //---------------------------
        testSiteMap[8, 11] = new Tile(livingRoom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -8, 11);
        testSiteMap[8, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -8, 12);
        testSiteMap[8, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -8, 13);
        testSiteMap[8, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -8, 14);
        testSiteMap[8, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -8, 15);

        //---------------------------------------------------------------

        testSiteMap[9, 0] = new Tile(bathroom, new bool[4] { true, true, false, false }, null, null, null, "tiles01", -9, 0);
        testSiteMap[9, 1] = new Tile(bathroom, new bool[4] { true, false, false, false }, null, null, null, "tiles01", -9, 1);
        testSiteMap[9, 2] = new Tile(bathroom, new bool[4] { true, false, false, false }, null, null, null, "tiles01", -9, 2);
        testSiteMap[9, 3] = new Tile(bathroom, new bool[4] { true, false, false, false }, null, null, null, "tiles01", -9, 3);
        testSiteMap[9, 4] = new Tile(bathroom, new bool[4] { true, false, false, false }, null, null, null, "tiles01", -9, 4);
        testSiteMap[9, 5] = new Tile(bathroom, new bool[4] { true, false, false, false }, null, null, null, "tiles01", -9, 5);
        testSiteMap[9, 6] = new Tile(bathroom, new bool[4] { true, false, false, false }, null, new bool[4] { false, false, false, true }, new bool[4] { false, false, false, true }, "tiles01", -9, 6);
        //---------------------------
        testSiteMap[9, 7] = new Tile(hall, null, null, new bool[4] { false, true, false, false }, new bool[4] { false, true, false, false }, "tiles01", -9, 7);
        testSiteMap[9, 8] = new Tile(hall, null, null, null, null, "tiles01", -9, 8);
        testSiteMap[9, 9] = new Tile(hall, null, null, null, null, "tiles01", -9, 9);
        testSiteMap[9, 10] = new Tile(hall, null, null, new bool[4] { false, false, false, true }, null, "tiles01", -9, 10);
        //---------------------------
        testSiteMap[9, 11] = new Tile(livingRoom, null, null, new bool[4] { false, true, false, false }, null, "wood1", -9, 11);
        testSiteMap[9, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -9, 12);
        testSiteMap[9, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -9, 13);
        testSiteMap[9, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -9, 14);
        testSiteMap[9, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -9, 15);

        //---------------------------------------------------------------

        testSiteMap[10, 0] = new Tile(bathroom, new bool[4] { false, true, false, false }, null, null, null, "tiles01", -10, 0);
        testSiteMap[10, 1] = new Tile(bathroom, new bool[4] { false, false, false, false }, null, null, null, "tiles01", -10, 1);
        testSiteMap[10, 2] = new Tile(bathroom, new bool[4] { false, false, false, false }, null, null, null, "tiles01", -10, 2);
        testSiteMap[10, 3] = new Tile(bathroom, new bool[4] { false, false, false, false }, null, null, null, "tiles01", -10, 3);
        testSiteMap[10, 4] = new Tile(bathroom, new bool[4] { false, false, false, false }, null, null, null, "tiles01", -10, 4);
        testSiteMap[10, 5] = new Tile(bathroom, new bool[4] { false, false, false, false }, null, null, null, "tiles01", -10, 5);
        testSiteMap[10, 6] = new Tile(bathroom, new bool[4] { false, false, false, true }, null, null, null, "tiles01", -10, 6);
        //---------------------------
        testSiteMap[10, 7] = new Tile(hall, new bool[4] { false, true, false, false }, null, null, null, "tiles01", -10, 7);
        testSiteMap[10, 8] = new Tile(hall, null, null, null, null, "tiles01", -10, 8);
        testSiteMap[10, 9] = new Tile(hall, null, null, null, null, "tiles01", -10, 9);
        testSiteMap[10, 10] = new Tile(hall, new bool[4] { false, false, false, true }, null, null, null, "tiles01", -10, 10);
        //---------------------------
        testSiteMap[10, 11] = new Tile(livingRoom, new bool[4] { false, true, false, false }, null, null, null, "wood1", -10, 11);
        testSiteMap[10, 12] = new Tile(livingRoom, null, null, null, null, "wood1", -10, 12);
        testSiteMap[10, 13] = new Tile(livingRoom, null, null, null, null, "wood1", -10, 13);
        testSiteMap[10, 14] = new Tile(livingRoom, null, null, null, null, "wood1", -10, 14);
        testSiteMap[10, 15] = new Tile(livingRoom, new bool[4] { false, false, false, true }, null, null, null, "wood1", -10, 15);

        //---------------------------------------------------------------

        testSiteMap[11, 0] = new Tile(bathroom, new bool[4] { false, true, true, false }, null, null, null, "tiles01", -11, 0);
        testSiteMap[11, 1] = new Tile(bathroom, new bool[4] { false, false, true, false }, null, null, null, "tiles01", -11, 1);
        testSiteMap[11, 2] = new Tile(bathroom, new bool[4] { false, false, true, false }, null, null, null, "tiles01", -11, 2);
        testSiteMap[11, 3] = new Tile(bathroom, new bool[4] { false, false, true, false }, null, null, null, "tiles01", -11, 3);
        testSiteMap[11, 4] = new Tile(bathroom, new bool[4] { false, false, true, false }, null, null, null, "tiles01", -11, 4);
        testSiteMap[11, 5] = new Tile(bathroom, new bool[4] { false, false, true, false }, null, null, null, "tiles01", -11, 5);
        testSiteMap[11, 6] = new Tile(bathroom, new bool[4] { false, false, true, true }, null, null, null, "tiles01", -11, 6);
        //---------------------------
        testSiteMap[11, 7] = new Tile(hall, new bool[4] { false, true, true, false }, null, null, null, "tiles01", -11, 7);
        testSiteMap[11, 8] = new Tile(hall, null, null, new bool[4] { false, false, true, false }, new bool[4] { false, false, true, false }, "tiles01", -11, 8);
        testSiteMap[11, 9] = new Tile(hall, new bool[4] { false, false, true, false }, null, null, null, "tiles01", -11, 9);
        testSiteMap[11, 10] = new Tile(hall, new bool[4] { false, false, true, true }, null, null, null, "tiles01", -11, 10);
        //---------------------------
        testSiteMap[11, 11] = new Tile(livingRoom, new bool[4] { false, true, true, false }, null, null, null, "wood1", -11, 11);
        testSiteMap[11, 12] = new Tile(livingRoom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -11, 12);
        testSiteMap[11, 13] = new Tile(livingRoom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -11, 13);
        testSiteMap[11, 14] = new Tile(livingRoom, new bool[4] { false, false, true, false }, null, null, null, "wood1", -11, 14);
        testSiteMap[11, 15] = new Tile(livingRoom, new bool[4] { false, false, true, true }, null, null, null, "wood1", -11, 15);

        //---------------------------------------------------------------


        Site testMap = new Site(new Room[]{ bedroom },testSiteMap,16,12);
        activeSite = testMap;

        DrawMap(testMap);

    } 

    public void DrawMap(Site site)
    {
        GameObject mapHolder = new GameObject("MapHolder");
        GameObject innerMapHolder = new GameObject("InnerMapHolder");
        innerMapHolder.transform.SetParent(mapHolder.transform);
        BoxCollider collider= innerMapHolder.AddComponent<BoxCollider>();
        collider.size = new Vector2(site.width, site.height);
        collider.center = new Vector2(site.width*0.5f-0.5f, site.height * (-0.5f)+0.5f);

        GameObject mask = new GameObject("NoiseMask");
        mask.transform.SetParent(mapHolder.transform);
        mask.AddComponent<SpriteRenderer>();
        MapNoise noiseGen = mask.AddComponent<MapNoise>();

        GameObject flatMask = new GameObject("FlatMask");
        flatMask.transform.SetParent(mapHolder.transform);
        flatMask.AddComponent<SpriteRenderer>();
        MapNoise noiseGen2 = flatMask.AddComponent<MapNoise>();

        for (int i = 0; i < site.map.GetLength(0); i++)
        {
            for (int j = 0; j < site.map.GetLength(1); j++)
            {
                GameObject tile = GenerateTileVisual(site.map[i,j]);
                tile.transform.SetParent(innerMapHolder.transform);
            }
        }

        noiseGen.LetThereBeNoise(site.width*(int)tileScale, site.height*(int)tileScale, tileScale);
        noiseGen2.LetThereBeNoise(site.width * (int)tileScale, site.height * (int)tileScale, tileScale, false);

        DrawFurniture(site).transform.SetParent(mapHolder.transform);
    }
    public GameObject DrawFurniture(Site site)
    {
        GameObject furnitureHolder = new GameObject("furnitureHolder");
        foreach(Room r in site.rooms)
        {
            foreach(Furniture f in r.furniture)
            {
                GameObject furnitureVis = GenerateFurnitureVisual(f);
                furnitureVis.transform.SetParent(furnitureHolder.transform);
            }
        }
        return furnitureHolder;
    }
    private GameObject GenerateTileVisual(Tile tile)
    {
        //Generate parent GameObject
        GameObject tileVisuals = new GameObject(tile.yCoord + " x " + tile.xCoord);
        tileVisuals.transform.position = new Vector3(tile.yCoord, tile.xCoord);

        //Call a function to generate a game object with walls visuals and add it to the parent (if there are any walls)
        GameObject wallsVisuals = GenerateWallsAndWindowsVisuals(tile);
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

    private GameObject GenerateWallsAndWindowsVisuals(Tile tile)
    {

        //Check what walls if any surround the tile.
        Texture2D tex = null;

        if (tile.north.hasWall)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord +" generated North wall as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/N");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated North wall as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/N"), true);
            }
        }
        else if (tile.north.hasWindow)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated North window as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowN");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated North window as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/windowN"),true);
            }
        }
        if (tile.west.hasWall)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West wall as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/W");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West wall as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/W"), true,true);
            }
        }
        else if (tile.west.hasWindow)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West window as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowW");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated West window as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/windowW"), true);
            }
        }
        if (tile.south.hasWall)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South wall as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/S");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South wall as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/S"), true);
            }
        }
        else if (tile.south.hasWindow)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South window as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowS");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated South window as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/windowS"), true);
            }
        }
        if (tile.east.hasWall)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East wall as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/E");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East wall as its further.");
                tex = MergeTextures(tex, Resources.Load<Texture2D>("Sprites/TileWalls/E"), true);
            }
        }
        else if (tile.east.hasWindow)
        {
            if (tex == null)
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East window as its first.");
                tex = Resources.Load<Texture2D>("Sprites/TileWalls/windowE");
            }
            else
            {
                //Debug.Log("Tile: " + tile.yCoord + " x " + tile.xCoord + " generated East window as its further.");
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
        Texture2D tex;
        if (tile.floorType == "wood1")
        {
            int floorSprite = Random.Range(0, 6);
            tex = Resources.Load<Texture2D>("Sprites/TileFloors/" + tile.floorType + floorSprite);
        }
        else
        {
            tex = Resources.Load<Texture2D>("Sprites/TileFloors/" + tile.floorType);
        }
        
        sr.sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f,0.5f), tileScale);
        sr.sortingLayerName = "Floors";
        //int floorRotation = Random.Range(0, 2);
        //floorVisuals.transform.rotation = Quaternion.AngleAxis(floorRotation * 180f, new Vector3(0, 0, 1));

        return floorVisuals;
    }
   

    private Texture2D MergeTextures(Texture2D first,Texture2D second,bool firstOverridesSecond=false,bool debug=false)
    {
        Texture2D final = new Texture2D(first.width, first.height);
        final.filterMode = FilterMode.Point;
        for (int x = 0; x < first.width; x++)
        {
            for (int y = 0; y < first.height; y++)
            {
                Color firstColor = first.GetPixel(x, y);             
                Color secondColor = second.GetPixel(x, y);
                Color finalColor = new Color();
                if (secondColor.a < 0.2)
                {
                    finalColor = firstColor;
                    
                }else if (firstColor.a < 0.2)
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
                        Debug.Log("Interpolating pixels");
                        finalColor = Color.Lerp(firstColor, secondColor, firstColor.a / 1.0f);
                    }
                    
                }
                
                final.SetPixel(x, y, finalColor);
            }
        }
        final.Apply();
        return final;

    }

    private GameObject GenerateFurnitureVisual(Furniture f)
    {
        GameObject furniture = new GameObject(f.furnitureType.PrintableName);
        SpriteRenderer sr = furniture.AddComponent<SpriteRenderer>();
        BoxCollider bc= furniture.AddComponent<BoxCollider>();
        bc.size = f.furnitureType.size;

        //Load a texture and create a sprite from it, and apply said sprite to the Sprite Renderer component.
        Texture2D tex = Resources.Load<Texture2D>("Sprites/Furniture/" + f.furnitureType.name);
        sr.sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), tileScale);
        sr.sortingLayerName = "Furniture";

        furniture.transform.position = f.position;
        furniture.transform.rotation *= f.orientation;

        return furniture;
    }

}
