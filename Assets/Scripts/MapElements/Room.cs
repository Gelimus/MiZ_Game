using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    /// <summary>
    /// The name of the room in a form that is GUI friendly and can be displayed on screen.
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// The category of the room (is it a bathroom, a bedroom etc.)
    /// </summary>
    string category;

    /// <summary>
    /// The list of every furniture in the room.
    /// </summary>
    public List<Furniture> furnitures { get; private set; }


    public readonly Tile[][] map; //jagged array


    /// <summary>
    /// The constructor that uses the category to create a name for this room;
    /// TODO: based on the category and maybe some other tags (like rich, children, toys etc.) 
    /// the constructor should call appropriate functions that would generate appropriate furniture
    /// for the room.
    /// </summary>
    /// <param name="category">The category of the room to be generated</param>
    public Room(string category)
    {
        this.category = category;
        this.Name = category;


        //FOR TESTING
        furnitures = new List<Furniture>();

        List<Item> items = new List<Item>();

        items.Add(new Item("Pillow"));
        items.Add(new Item("Knife"));

        List<FurnitureAction> actions=new List<FurnitureAction>();
        actions.Add(new SearchAction());
        FurnitueType bed = new FurnitueType("Bed",actions);
        actions = new List<FurnitureAction>();
        actions.Add(new SearchAction());
        FurnitueType table = new FurnitueType("Table", actions);
        actions = new List<FurnitureAction>();
        actions.Add(new SearchAction());
        FurnitueType mirror = new FurnitueType("Mirror", actions);
        actions = new List<FurnitureAction>();
        actions.Add(new SearchAction());
        FurnitueType chair = new FurnitueType("Chair", actions);
        actions = new List<FurnitureAction>();
        actions.Add(new SearchAction());
        FurnitueType lamp = new FurnitueType("Lamp", actions);


        furnitures.Add(new Furniture(bed,items));
        items = new List<Item>();
        items.Add(new Item("Book: Witcher"));
        items.Add(new Item("Family Photo"));
        items.Add(new Item("Bottle of Beer"));
        items.Add(new Item("Beautiful green plant"));
        furnitures.Add(new Furniture(table,items));
        furnitures.Add(new Furniture(mirror,items));
        furnitures.Add(new Furniture(chair,items));
        furnitures.Add(new Furniture(lamp,items));
        //END FOR TESTING

    }

    public Room(Tile[][] map)
    {
        this.map = map;
    }


}
