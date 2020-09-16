using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture 
{
    /// <summary>
    /// The name of the piece of furniture in a form that is GUI friendly and can be displayed on screen.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// The list of every item in the room.
    /// </summary>
    public List<Item> items { get; private set; }
    /// <summary>
    /// A constructor that takes the name of the furniture.
    /// TODO: Make a category variable and construct with it. 
    /// Name should be auto genereted as should be the items.
    /// </summary>
    /// <param name="name"></param>
    public Furniture(string name)
    {
        Name = name;
    }

    /// <summary>
    /// A temporary constructor for testing purposes.
    /// TODO: Delete this when proper Furniture generation will be in place.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="items"></param>
    public Furniture(string name,List<Item> items)
    {
        Name = name;
        this.items = items;
    }

    public Item RemoveItemAtIndex(int index)
    {
        Item returnItem = items[index];

        items.RemoveAt(index);
        return returnItem;
    }
}
