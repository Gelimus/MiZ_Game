using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text.Json;
using System.Text.Json.Serialization;

public static class ItemTypesCollection
{
    private static Dictionary<string, ItemType> types = new Dictionary<string, ItemType>();


    public static ItemType getItemType(string name)
    {
        if (types.ContainsKey(name))
        {
            return types[name];
        }
        else
        {
           
            string jsonString = File.ReadAllText("ItemTypes");
            JsonDocument jDoc = JsonDocument.Parse(jsonString);
            jDoc.
            weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
        }
    }
}
