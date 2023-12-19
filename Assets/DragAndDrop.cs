using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 initialPosition;
    public static float val;
    public static int id;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    InventoryManager.Wallet += val;
                    Debug.Log(MapItem.Map[id]);
                    MapItem.Map.Remove(id);
                    Destroy(gameObject);
                }
            }
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = GetMouseWorldPos() + offset;
        transform.position = newPosition;
        MapItem.Map[id] = newPosition;
    }

    private Vector3 GetMouseWorldPos()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }
        return transform.position;
    }

    private void ResetAllPositions()
    {
        DragAndDrop[] allDraggableObjects = FindObjectsOfType<DragAndDrop>();
        foreach (var obj in allDraggableObjects)
        {
            obj.transform.position = obj.initialPosition;
        }
    }
}
