using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{

    public string Name { get; private set; }
    string category;

    public List<Furniture> furnitures { get; private set; }
   
    public Room(string category)
    {
        this.category = category;
        this.Name = category;


        //FOR TESTING
        furnitures = new List<Furniture>();

        List<Item> items = new List<Item>();

        items.Add(new Item("Pillow"));
        items.Add(new Item("Knife"));

        furnitures.Add(new Furniture("Bed",items));
        items.Clear();
        items.Add(new Item("Book: Witcher"));
        items.Add(new Item("Family Photo"));
        items.Add(new Item("Bottle of Beer"));
        furnitures.Add(new Furniture("Table",items));
        furnitures.Add(new Furniture("Mirror"));
        furnitures.Add(new Furniture("Chair"));
        furnitures.Add(new Furniture("Lamp"));


    }




}
