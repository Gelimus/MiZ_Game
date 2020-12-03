using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FurnitureAction 
{
    private bool actionEnabled=true;
    public bool Enabled
    {
        get { return actionEnabled; }
    }


    public virtual void performAction() {
        Debug.Log("Action Performeded");
    }

    public abstract FurnitureAction CloneAction();

    public void DisableAction()
    {
        
        if (actionEnabled)
        {
            actionEnabled = false;
        }
        else
        {
            Debug.LogWarning("An already disabled action was attempted to be disabled");
        }
    }

    public void EnableAction()
    {
        if (!actionEnabled)
        {
            actionEnabled = true;
        }
        else
        {
            Debug.LogWarning("An already enabled action was attempted to be enabled");
        }
    }
}
