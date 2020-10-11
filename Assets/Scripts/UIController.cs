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
    private static GameObject PartyPanel;

    /// <summary>
    /// A reference to the GameObject representing the page of the LeftPanel, 
    /// that shows all items in the inventory of all characters on the current 
    /// scavenging mission.
    /// </summary>
    private static GameObject InventoryPanel;

    /// <summary>
    /// A reference to the GameObject representing the page of the LeftPanel, 
    /// that shows all events that happened on the current expedition
    /// </summary>
    private static GameObject LogPanel;

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
    private static GameObject activePanel;

    /// <summary>
    /// The currently selected room to be displayed on the right panel.
    /// </summary>
    private Room selectedRoom;

    static private Party currentParty;

    /// <summary>
    /// A dictionary holding a link between a data model of a furniture and the UI element in the RightPanel representing it.
    /// </summary>
    private static Dictionary<GameObject, Furniture> furnitureReference;

    // Start is called before the first frame update
    void Start()
    {
        PartyPanel = GameObject.Find("PartyPanel");
        InventoryPanel = GameObject.Find("InventoryPanel");
        LogPanel = GameObject.Find("LogPanel");

        //Setting the activePanel to the PartyPanel as a default state.
        activePanel = PartyPanel;
        InventoryPanel.SetActive(false);
        LogPanel.SetActive(false);
        //TODO: part of the cleaning of the double font variable.
        mF = mainFont;
        //FOR TESTING PURPOSES, fake room selected
        ChangeSelectedRoom(new Room("Bedroom"));
        currentParty = new Party();
    }

    // Update is called once per frame
    void Update()
    {
        //Part of the stupid solution for the double click problem
        if (TMPFixForStupidBUG > 0f)
        {
            TMPFixForStupidBUG -= Time.deltaTime;
        }
        if (itemDoubleClickTimer > 0f)
        {
            itemDoubleClickTimer -= Time.deltaTime;
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
            ((Text)furniturePanel.GetComponentInChildren<Text>()).text = f.furnitureType.Name;
            ((Button)furniturePanel.GetComponentInChildren<Button>()).onClick.AddListener(delegate { ShowFurnitureItems(furniturePanel); });

            furnitureReference.Add(furniturePanel, f);


            UpdateFurnitureActionIcons(furniturePanel);
        }
    }

    private void UpdateFurnitureActionIcons(GameObject furniturePanel)
    {

        Furniture f;
        if (!furnitureReference.TryGetValue(furniturePanel, out f))
        {
            Debug.LogError("Nie znaleziono mebla!!!");
        }

        Transform actionButtonsContainer = furniturePanel.transform.Find("NotContents").Find("ActionsButtons");

        foreach (Transform child in actionButtonsContainer)
        {
            GameObject.Destroy(child.gameObject);
        }


        foreach (FurnitureAction fa in f.furnitureType.actions)
        {
            if (fa.Enabled)
            {
                GameObject actionButton = new GameObject(fa.GetType().Name);
                actionButton.transform.SetParent(actionButtonsContainer);

                Image i = actionButton.AddComponent<Image>();

                Texture2D tex = Resources.Load<Texture2D>("Sprites/UIElements/FurnitureActions/" + fa.GetType().Name.ToLower());
                i.sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), Vector2.zero, 200f);


                Button b = actionButton.AddComponent<Button>();
                b.onClick.AddListener(delegate { fa.performAction(); });
                b.onClick.AddListener(delegate { UpdateFurnitureItemListVisuals(furniturePanel); });
                b.onClick.AddListener(delegate { UpdateFurnitureActionIcons(furniturePanel); });
            }
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
            GameObject fc = new GameObject("FurnitureContents");
            VerticalLayoutGroup vLG = fc.AddComponent(typeof(VerticalLayoutGroup)) as VerticalLayoutGroup;
            vLG.spacing = 5;
            vLG.childForceExpandHeight = false;
            fc.transform.SetParent(furniturePanel.transform);

            UpdateFurnitureItemListVisuals(furniturePanel);
        }
        else
        {
            furniturePanel.transform.GetChild(1).gameObject.SetActive(!furniturePanel.transform.GetChild(1).gameObject.activeSelf);
        }
    }

    public static void UpdateFurnitureItemListVisuals(GameObject furniturePanel)
    {
        Furniture furniture;
        if (!furnitureReference.TryGetValue(furniturePanel, out furniture))
        {
            Debug.LogError("Nie znaleziono mebla!!!");
        }

        if (furniturePanel.transform.childCount < 2)
        {
            Debug.LogWarning("The item visuals of a furniture: " + furniture.furnitureType.Name + " were attempted to be updated, when they were never displayed in the first place." +
                "This is a normal behaviour but may indicate some unforseen interactions in the future.");
            return;
        }
            GameObject fc = furniturePanel.transform.Find("FurnitureContents").gameObject;
        foreach (Transform child in fc.transform)
        {
            GameObject.Destroy(child.gameObject);
        }


        if (furniture.contentsVisible())
        {
            for (int index = 0; index < furniture.items.Count; index++)
            {
                Item i = furniture.items[index];
                GameObject item = new GameObject(index.ToString());
                Text t = item.AddComponent(typeof(Text)) as Text;
                t.text = i.Name;
                t.font = mF;
                t.fontSize = 12;
                item.transform.SetParent(fc.transform);

                Button b = item.AddComponent(typeof(Button)) as Button;
                b.onClick.AddListener(delegate { OnItemClicked(item); });

            }
        }
        else
        {
            GameObject item = new GameObject("Unsearched");
            Text t = item.AddComponent(typeof(Text)) as Text;
            t.text = "Unsearched";
            t.font = mF;
            t.fontSize = 12;
            item.transform.SetParent(fc.transform);
        }


    }

    private static float itemDoubleClickTimer;
    public static void OnItemClicked(GameObject itemPanel)
    {
        if (itemDoubleClickTimer <= 0)
        {
            itemDoubleClickTimer = 0.5f;
        }
        else
        {
            CollectItem(itemPanel);
        }
    }

    public static void CollectItem(GameObject itemPanel)
    {
        Furniture furniture;
        GameObject furniturePanel = itemPanel.transform.parent.parent.gameObject;
        if (!furnitureReference.TryGetValue(furniturePanel, out furniture))
        {
            Debug.LogError("Nie znaleziono mebla!!!");
        }

        int itemNumber = Int32.Parse(itemPanel.name);
        Item i = furniture.RemoveItemAtIndex(itemNumber);
        currentParty.AddItemToInventory(i);

        itemPanel.transform.SetParent(null); 
        GameObject.Destroy(itemPanel);


        Transform furnitureContents = furniturePanel.transform.GetChild(1);
        if (furnitureContents.childCount == 0)
        {
            furnitureContents.transform.SetParent(null);
            Destroy(furnitureContents.gameObject);
        }
        for (int index = itemNumber; index < furnitureContents.childCount; index++)
        {
            furnitureContents.GetChild(index).gameObject.name = index.ToString();
        }

        if (InventoryPanel.activeSelf)
        {
            UpdateInventoryPanel();
        }

    }

    public static void UpdateInventoryPanel()
    {
        while (InventoryPanel.transform.childCount > 0)
        {
            GameObject item = InventoryPanel.transform.GetChild(0).gameObject;
            item.transform.SetParent(null);
            GameObject.Destroy(item);
        }
        foreach (Item i in currentParty.Inventory)
        {
            GameObject item = new GameObject();
            Text t = item.AddComponent(typeof(Text)) as Text;
            t.text = i.Name;
            t.font = mF;
            t.fontSize = 12;
            item.transform.SetParent(InventoryPanel.transform);
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
            UpdateInventoryPanel();
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
