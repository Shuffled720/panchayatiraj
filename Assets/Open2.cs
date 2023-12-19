using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open2 : MonoBehaviour
{
    public Transform Inv;
    public Transform Backpack;

    void Start()
    {
        Inv.gameObject.SetActive(false);
        Backpack.gameObject.SetActive(true);
    }

    void Update()
    {
        ToggleInv();
    }

    void ToggleInv()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inv.gameObject.SetActive(!Inv.gameObject.activeSelf);
        }
        if (Inv.gameObject.activeSelf) 
        {
            // ListItems();
            Backpack.gameObject.SetActive(false);
        }
        else
        {
            Backpack.gameObject.SetActive(true);
        }
    }
}
