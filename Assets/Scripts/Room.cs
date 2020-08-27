using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{

    public string Name { get; private set; }
    string category;
   
    public Room(string category)
    {
        this.category = category;
        this.Name = category;
    }
}
