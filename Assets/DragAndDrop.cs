using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = GetMouseWorldPos() + offset;
        transform.position = newPosition;

        // Check for speculative collisions
        if (WillCollide())
        {
            // If collision is predicted, reset positions for all objects
            ResetAllPositions();
        }
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

    private bool WillCollide()
    {
        // Create a box representing the potential new position
        Bounds newBounds = new Bounds(transform.position, transform.localScale);

        // Check for collisions with other objects
        Collider[] colliders = Physics.OverlapBox(newBounds.center, newBounds.extents);
        foreach (var collider in colliders)
        {
            if (collider.gameObject != gameObject)
            {
                // Collision predicted
                return true;
            }
        }

        // No collision predicted
        return false;
    }

    private void ResetAllPositions()
    {
        // Reset positions for all objects
        DragAndDrop[] allDraggableObjects = FindObjectsOfType<DragAndDrop>();
        foreach (var obj in allDraggableObjects)
        {
            obj.transform.position = obj.initialPosition;
        }
    }
}
