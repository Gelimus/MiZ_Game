﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchAction: FurnitureAction
{
    private bool searched=false;

    public override void performAction()
    {
        if (!searched)
        {
            //TODO: Check if a character is in the same Room as the Furniture

            searched = true;
        }
    }

    public bool isSearched()
    {
        return searched;
    }
}
