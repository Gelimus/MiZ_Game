using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture 
{
    public readonly string name;
    public FurnitureType furnitureType;
    /// <summary>
    /// The list of every item in the room.
    /// </summary>
    public List<Item> items { get; private set; }

    public Vector2 position;
    public Quaternion orientation;
    /// <summary>
    /// A constructor that takes the name of the furniture.
    /// TODO: Make a category variable and construct with it. 
    /// Name should be auto genereted as should be the items.
    /// </summary>
    /// <param name="name"></param>
    public Furniture(string name, FurnitureType ft, Vector2 position, Quaternion orientation)
    {
        this.name = name;
        furnitureType = ft;
        this.orientation = orientation;

        setTruePosition(position);

    }

    /// <summary>
    /// A temporary constructor for testing purposes.
    /// TODO: Delete this when proper Furniture generation will be in place.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="items"></param>
    public Furniture(string name, FurnitureType ft, Vector2 position, Quaternion orientation, List<Item> items)
    {
        furnitureType = ft;
        this.orientation = orientation;
        setTruePosition(position);
        
        
        this.items = items;
    }
    private void setTruePosition(Vector2 pos)
    {
        Vector2 size = furnitureType.size;
        size = orientation * size;
        
        Debug.Log(size);
        pos.x += (Mathf.Abs(size.x) * 0.5f-0.5f);
        pos.y -= (Mathf.Abs(size.y) * 0.5f-0.5f);
        position = pos;
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
