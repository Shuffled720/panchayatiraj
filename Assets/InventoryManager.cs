using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static float Wallet;
    public static int genId = 0;
    void Start()
    {
        Wallet = 1000;
    }

    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public InventoryItemController[] InventoryItems;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove2DItem(int itemIndex)
    {
        Items.RemoveAt(itemIndex);
        ListItems();
    }

    public void ListItems()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            // var itemName = obj.transform.Find("ItemName").GetComponent<Text>();

            var itemIcon = obj.transform.Find("Icon").GetComponent<Image>();
            itemIcon.sprite = item.icon;

            obj.GetComponent<Button>().onClick.AddListener(() => Instantiate3DItem(item));
        }

        SetInventoryItems();
    }

    public void SetInventoryItems()
    {
        InventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>();

        for (int i = 0; i < Items.Count; i++)
        {
            InventoryItems[i].AddItem(Items[i], i);
        }
    }

    public void Instantiate3DItem(Item item)
    {
        if (Wallet >= item.value)
        {
            DragAndDrop.val = item.value;
            Wallet -= item.value;
            MapItem.Map.Add(genId, Vector3.zero);
            DragAndDrop.id = genId++;
            Camera mainCamera = Camera.main;

            Vector3 cameraDirection = mainCamera.transform.forward;
            Vector3 spawnPosition = mainCamera.transform.position + 10f * cameraDirection;

            GameObject obj = Instantiate(item.prefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Insufficient funds to purchase item: " + item.itemName);
        }
    }
}
