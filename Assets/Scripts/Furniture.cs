using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture 
{
    public FurnitueType furnitureType;
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
    public Furniture(FurnitueType ft)
    {
        furnitureType = ft;
    }

    /// <summary>
    /// A temporary constructor for testing purposes.
    /// TODO: Delete this when proper Furniture generation will be in place.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="items"></param>
    public Furniture(FurnitueType ft,List<Item> items)
    {
        furnitureType = ft;
        this.items = items;
    }

    public Item RemoveItemAtIndex(int index)
    {
        Item returnItem = items[index];

        items.RemoveAt(index);
        return returnItem;
    }

    public bool contentsVisible()
    {
        foreach(FurnitureAction fa in furnitureType.actions)
        {
            if (fa.GetType().Name == "SearchAction")
            {
                return ((SearchAction)fa).isSearched();
            }
        }

        Debug.LogWarning("Furniture without search action");
        return true;
    }

}
