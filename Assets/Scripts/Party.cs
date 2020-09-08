using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party
{
   
    public List<Item> Inventory
    {
        get;
        private set;
    }

    public Party()
    {
        Inventory = new List<Item>();
    }

    public void AddItemToInventory(Item i)
    {
        Inventory.Add(i);
    }

}
