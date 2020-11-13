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
    public List<Furniture> furniture { get; private set; }


    //public readonly Tile[][] map; //jagged array


    /// <summary>
    /// The constructor that uses the category to create a name for this room;
    /// TODO: based on the category and maybe some other tags (like rich, children, toys etc.) 
    /// the constructor should call appropriate functions that would generate appropriate furniture
    /// for the room.
    /// </summary>
    /// <param name="category">The category of the room to be generated</param>
    //public Room(string category)
    //{
    //    this.category = category;
    //    this.Name = category;


    //    //FOR TESTING
    //    furniture = new List<Furniture>();

    //    List<Item> items = new List<Item>();

    //    items.Add(new Item("Pillow"));
    //    items.Add(new Item("Knife"));

    //    List<FurnitureAction> actions = new List<FurnitureAction>();
    //    actions.Add(new SearchAction());
    //    FurnitureType bed = new FurnitureType("bed","Bed",new Vector2(1,1), actions);
    //    actions = new List<FurnitureAction>();
    //    actions.Add(new SearchAction());
    //    FurnitureType table = new FurnitureType("table","Table",new Vector2(1,1), actions);
    //    actions = new List<FurnitureAction>();
    //    actions.Add(new SearchAction());
    //    FurnitureType mirror = new FurnitureType("mirror","Mirror", new Vector2(1,1), actions);
    //    actions = new List<FurnitureAction>();
    //    actions.Add(new SearchAction());
    //    FurnitureType chair = new FurnitureType("chair","Chair", new Vector2(1,1), actions);
    //    actions = new List<FurnitureAction>();
    //    actions.Add(new SearchAction());
    //    FurnitureType lamp = new FurnitureType("lamp","Lamp", new Vector2(1,1), actions);


    //    furniture.Add(new Furniture("Bed", bed,Vector2.one,Quaternion.identity, items));
    //    items = new List<Item>();
    //    items.Add(new Item("Book: Witcher"));
    //    items.Add(new Item("Family Photo"));
    //    items.Add(new Item("Bottle of Beer"));
    //    items.Add(new Item("Beautiful green plant"));
    //    //furniture.Add(new Furniture(table, items));
    //    //furniture.Add(new Furniture(mirror, items));
    //    //furniture.Add(new Furniture(chair, items));
    //    //furniture.Add(new Furniture(lamp, items));
    //    //END FOR TESTING

    //}

    public Room(List<Furniture> furniture,string name)
    {
        Name = name;
        this.furniture = furniture;
    }


}
