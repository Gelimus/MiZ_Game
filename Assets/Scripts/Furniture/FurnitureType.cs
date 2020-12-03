using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureType 
{
    public readonly string name;
    public readonly string PrintableName;
    

    /// <summary>
    /// The actions here are a blueprint to be copied ONLY. It is not supposed to be copied or accessed
    /// </summary>
    public List<FurnitureAction> Actions { get; private set;}

    public readonly Vector2 size;


    public FurnitureType(string name, string printableName, Vector2 size, List<FurnitureAction> actions)
    {
        this.name = name;
        PrintableName = printableName;
        this.size = size;

        this.Actions = actions;
    }

}

