using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureType 
{
    public readonly string name;
    public string PrintableName;
    
    public List<FurnitureAction> actions;

    public readonly Vector2 size;


    public FurnitureType(string name, string printableName, Vector2 size, List<FurnitureAction> actions)
    {
        this.name = name;
        PrintableName = printableName;
        this.size = size;

        this.actions = actions;
    }

}

