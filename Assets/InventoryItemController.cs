using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public Item item;
    public int itemIndex;
    public void Remove2DItem()
    {
        InventoryManager.Instance.Remove2DItem(itemIndex);

        Destroy(gameObject);
    }

    public void AddItem(Item newItem, int index)
    {
        item = newItem;
        itemIndex = index;
    }
}
