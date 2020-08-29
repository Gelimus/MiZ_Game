using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject PartyPanel;
    public GameObject InventoryPanel;
    public GameObject LogPanel;

    public GameObject RightPanel;

    public GameObject SelectedLocationName;

    private GameObject activePanel;

    private Room selectedRoom;

    public GameObject FurniturePanelPrefab;


    private Dictionary<GameObject, Furniture> furnitureReference;

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
        furnitureReference = new Dictionary<GameObject, Furniture>();

        foreach(Furniture f in selectedRoom.furnitures)
        {
            GameObject furniture = GameObject.Instantiate(FurniturePanelPrefab, RightPanel.transform);
            ((Text)furniture.GetComponentInChildren<Text>()).text = f.Name;
            ((Button)furniture.GetComponent<Button>()).onClick.AddListener(delegate{ ShowFurnitureItems(furniture); });
            furnitureReference.Add(furniture, f);
        }
    }
    public void ShowFurnitureItems(GameObject furniturePanel)
    {
        Furniture furniture;
        if(!furnitureReference.TryGetValue(furniturePanel,out furniture))
        {
            Debug.LogError("Nie znaleziono mebla!!!");
        }
        

        foreach (Item i in furniture.items)
        {
            GameObject item = new GameObject();
            Text t = item.AddComponent(typeof(Text)) as Text;
            t.text = i.Name;
            item.transform.SetParent(furniturePanel.transform);
        }
    }
}
