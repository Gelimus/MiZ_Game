using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitueType 
{

    public string Name;
    public List<FurnitureAction> actions;


    public FurnitueType(string name, List<FurnitureAction> actions)
    {
        Name = name;
        this.actions = actions;
    }

}

