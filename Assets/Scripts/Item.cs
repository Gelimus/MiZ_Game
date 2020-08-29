using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string Name { get; private set; }

    public Item(string name)
    {
        Name = name;
    }
}
