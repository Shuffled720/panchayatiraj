using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveItem : MonoBehaviour
{
    Item item;

    // public Button RemoveButton;

    void Pickup()
    {
        InventoryManager.Instance.Add(item);
        // Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Pickup();
    }

    // public void RemoveItem()
    // {
    //     InventoryManager.Instance.Remove(item);
    // }

    // public void AddItem(Item newItem)
    // {
    //     item = newItem;
    // }
}
