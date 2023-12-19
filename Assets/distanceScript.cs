using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DistanceToTarget : MonoBehaviour
{
    

    public List<Vector3> vectorList ;

    // Reference to the target location
    public Vector3 targetPosition = new Vector3(1000f, 0f, 1000f);

    // Reference to the UI text element
    public Text distanceText;

    private void Start()
    {
        vectorList.Add(new Vector3(100,100,100));
        vectorList.Add(new Vector3(200,200,200));
        vectorList.Add(new Vector3(300,300,300));
    }
    // Update is called once per frame
    void Update()
    {
        // Loop through each vector in the list
        foreach (Vector3 vector in vectorList)
        {
            // Calculate the distance to the target
            float distance = Vector3.Distance(vector, targetPosition);

            // Update the UI text with the distance value
            distanceText.text =  distance.ToString("F2") ;
        }
    }
}