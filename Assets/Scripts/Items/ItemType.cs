using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemType
{
    string name;
    string pritableName;
    /// <summary>
    /// From 0 to 100 in %
    /// </summary>
    public byte spawnChance
    {
        get { return spawnChance; }
        private set
        {
            if (value < 0)
            {
                spawnChance = 0;
            } else if (value > 100)
            {
                spawnChance = 100;
            }
            else
            {
                spawnChance = value;
            }
        }
    }

    public byte minNumberOfSpawns { get; private set; }
    public byte maxNumberOfSpawns { get; private set; }

    TagElement[] tags;

}
