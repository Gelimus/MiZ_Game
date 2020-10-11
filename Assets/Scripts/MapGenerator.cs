using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class MapGenerator 
{
    
    public static Site LoadSiteFromFile(string fileName)
    {
        Site site = new Site();

        string jsonString = File.ReadAllText(fileName);


        return site;
    }


}
