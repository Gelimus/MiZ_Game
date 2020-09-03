using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    
    //GRAFIC AND FONT REFERENCES

    /// <summary>
    /// The reference to the font that is to be used for GUI.
    /// </summary>
    public Font mainFont;

    /// <summary>
    /// The static reference to the mainFont needed for static methods.
    /// TODO: Maybe clean this up, becaouse two variables for the same thing don't seem
    /// like an elegant solution.
    /// </summary>
    private static Font mF;


    //GAME OBJECT REFERENCES

    /// <summary>
    /// A reference to the GameObject representing the page of the LeftPanel, 
    /// that shows all characters on the current scavenging mission.
    /// </summary>
    public GameObject PartyPanel;

    /// <summary>
    /// A reference to the GameObject representing the page of the LeftPanel, 
    /// that shows all items in the inventory of all characters on the current 
    /// scavenging mission.
    /// </summary>
    public GameObject InventoryPanel;

    /// <summary>
    /// A reference to the GameObject representing the page of the LeftPanel, 
    /// that shows all events that happened on the current expedition
    /// </summary>
    public GameObject LogPanel;

    /// <summary>
    /// A reference to the GameObject representing the RightPanel, 
    /// where contents of the current selected room are shown.
    /// </summary>
    public GameObject RightPanel;

    /// <summary>
    /// A reference to the GameObject that displays the name of
    /// the current selected room.
    /// </summary>
    public GameObject SelectedLocationName;

    //PREFABS

    /// <summary>
    /// A reference to the prefab for the panel containing info about a single furniture.
    /// </summary>
    public GameObject FurniturePanelPrefab;

    //CONTROL VARIABLES

    /// <summary>
    /// A variable representing currently active page on the LeftPanel,
    /// it should always be either the PartyPanel, the InventoryPanel,
    /// or the LogPanel
    /// </summary>
    private GameObject activePanel;

    /// <summary>
    /// The currently selected room to be displayed on the right panel.
    /// </summary>
    private Room selectedRoom;

    

    /// <summary>
    /// A dictionary holding a link between a data model of a furniture and the UI element in the RightPanel representing it.
    /// </summary>
    private static Dictionary<GameObject, Furniture> furnitureReference;

    // Start is called before the first frame update
    void Start()
    {
        //Setting the activePanel to the PartyPanel as a default state.
        activePanel = PartyPanel;
        //TODO: part of the cleaning of the double font variable.
        mF = mainFont;
        //FOR TESTING PURPOSES, fake room selected
        ChangeSelectedRoom(new Room("Bedroom"));
    }

    // Update is called once per frame
    void Update()
    {
        //Part of the stupid solution for the double click problem
        if (TMPFixForStupidBUG > 0f)
        {
            TMPFixForStupidBUG -= Time.deltaTime;
        }
    }


    /// <summary>
    /// A function that updates all appropriate GUI elements and internal variables
    /// when a new room is selected
    /// </summary>
    /// <param name="newRoom">The reference to the new selected room</param>
    private void ChangeSelectedRoom(Room newRoom)
    {
        selectedRoom = newRoom;
        ((Text)SelectedLocationName.GetComponent("Text")).text = selectedRoom.Name;
        furnitureReference = new Dictionary<GameObject, Furniture>();

        foreach(Furniture f in selectedRoom.furnitures)
        {
            
            GameObject furniturePanel = GameObject.Instantiate(FurniturePanelPrefab, RightPanel.transform);
            ((Text)furniturePanel.GetComponentInChildren<Text>()).text = f.Name;
            ((Button)furniturePanel.GetComponentInChildren<Button>()).onClick.AddListener(delegate { ShowFurnitureItems(furniturePanel); });

            furnitureReference.Add(furniturePanel, f);
        }
    }

    //A STUPID VARIABLE FOR A STUPID SOLUTION TODO: FIX
    private static float TMPFixForStupidBUG = 0f;
    /// <summary>
    /// A function that is called when a panel of a furniture is clicked to show or hide all items contained within.
    /// </summary>
    /// <param name="furniturePanel"></param>
    public static void ShowFurnitureItems(GameObject furniturePanel)
    {
        if (TMPFixForStupidBUG > 0f)
        {
            return;
        }
        else
        {
            TMPFixForStupidBUG = 0.001f;
        }
        
        if (furniturePanel.transform.childCount < 2)
        {
            Furniture furniture;
            if (!furnitureReference.TryGetValue(furniturePanel, out furniture))
            {
                Debug.LogError("Nie znaleziono mebla!!!");
            }

            GameObject fc = new GameObject("FurnitureContents");
            VerticalLayoutGroup vLG= fc.AddComponent(typeof(VerticalLayoutGroup)) as VerticalLayoutGroup;
            vLG.spacing = 5;
            vLG.childForceExpandHeight = false;
            fc.transform.SetParent(furniturePanel.transform);
            foreach (Item i in furniture.items)
            {
                GameObject item = new GameObject();
                Text t = item.AddComponent(typeof(Text)) as Text;
                t.text = i.Name;
                t.font = mF;
                t.fontSize = 12;
                item.transform.SetParent(fc.transform);
            }
        }
        else
        {
                furniturePanel.transform.GetChild(1).gameObject.SetActive(!furniturePanel.transform.GetChild(1).gameObject.activeSelf);
        }

    }




    /// <summary>
    /// A function for setting the active page on the left panel to the InventoryPanel
    /// </summary>
    public void ActivateInventoryPanel()
    {
        if (!InventoryPanel.activeSelf)
        {
            activePanel.SetActive(false);
            activePanel = InventoryPanel;
            activePanel.SetActive(true);
        }
    }
    /// <summary>
    /// A function for setting the active page on the left panel to the PartyPanel
    /// </summary>
    public void ActivatePartyPanel()
    {
        if (!PartyPanel.activeSelf)
        {
            activePanel.SetActive(false);
            activePanel = PartyPanel;
            activePanel.SetActive(true);
        }
    }
    /// <summary>
    /// A function for setting the active page on the left panel to the LogPanel
    /// </summary>
    public void ActivateLogPanel()
    {
        if (!LogPanel.activeSelf)
        {
            activePanel.SetActive(false);
            activePanel = LogPanel;
            activePanel.SetActive(true);
        }
    }
}
