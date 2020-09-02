using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item

{/// <summary>
 /// The name of the item in a form that is GUI friendly and can be displayed on screen.
 /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// A constructor that takes the name of the item.
    /// TODO: Make a category or id variable and construct with it, loading data from a file. 
    /// Name should be auto genereted as should be the other properties
    /// </summary>
    /// <param name="name"></param>
    public Item(string name)
    {
        Name = name;
    }
}
