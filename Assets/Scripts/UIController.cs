using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject PartyPanel;
    public GameObject InventoryPanel;
    public GameObject LogPanel;

    public GameObject SelectedLocationName;

    private GameObject activePanel;

    private Room selectedRoom;


    // Start is called before the first frame update
    void Start()
    {
        activePanel = PartyPanel;

        ChangeSelectedRoom(new Room("Bedroom"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateInventoryPanel()
    {
        if (!InventoryPanel.activeSelf)
        {
            activePanel.SetActive(false);
            activePanel = InventoryPanel;
            activePanel.SetActive(true);
        }
    }
    public void ActivatePartyPanel()
    {
        if (!PartyPanel.activeSelf)
        {
            activePanel.SetActive(false);
            activePanel = PartyPanel;
            activePanel.SetActive(true);
        }
    }
    public void ActivateLogPanel()
    {
        if (!LogPanel.activeSelf)
        {
            activePanel.SetActive(false);
            activePanel = LogPanel;
            activePanel.SetActive(true);
        }
    }

    private void ChangeSelectedRoom(Room newRoom)
    {
        selectedRoom = newRoom;
        ((Text)SelectedLocationName.GetComponent("Text")).text = selectedRoom.Name;
    }
}
