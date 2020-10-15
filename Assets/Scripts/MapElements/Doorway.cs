using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway 
{
    private bool isOpened;
    private bool hasDoor;

    /// <summary>
    /// This variable is a weight for doors to be opened compared to the weight of the chance for them to be closed;
    /// </summary>
    private const int doorOpenedProbabilityWeight = 1;
    /// <summary>
    /// This variable is a weight for doors to be closed compared to the weight of the chance for them to be opened;
    /// </summary>
    private const int doorClosedProbabilityWeight = 3;
    public Doorway(bool door)
    {
        hasDoor = door;
            if(Random.Range(0, doorClosedProbabilityWeight+doorOpenedProbabilityWeight)<doorOpenedProbabilityWeight)
            {
                isOpened = true;
            }
            else
            {
                isOpened = false;
            }
    }

    public void OpenDoor()
    {
        if (isOpened)
        {
            Debug.LogWarning("Door already opened!");
        }
        else
        {
            isOpened = true;
        }
    }

    public void CloseDoor()
    {
        if (isOpened)
        {
            isOpened = false;
        }
        else
        {
            Debug.LogWarning("Door already closed!");
        }
    }

}
