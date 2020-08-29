using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture 
{
    public string Name { get; private set; }
    public List<Item> items { get; private set; }
    public Furniture(string name)
    {
        Name = name;
    }
    public Furniture(string name,List<Item> items)
    {
        Name = name;
        this.items = items;
    }
}
