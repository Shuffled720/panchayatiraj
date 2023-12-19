using UnityEngine;

public class ActiveObject : MonoBehaviour
{
    public GameObject activeGameObject;

    public void ActivateObject(bool Ans)
    {
        Debug.Log("Hello!");
        activeGameObject.SetActive(true);
    }
}




// using UnityEngine;

// public class ActiveObject : MonoBehaviour
// {
//     public GameObject canvas;
//     int t = 1;

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.I))
//         {
//             Debug.Log("Change!");
//             ToggleCanvas();
//         }

//         if (Input.GetKeyDown(KeyCode.O))
//         {
//             Debug.Log("Change!");
//             ToggleCanvas();
//         }
//     }

//     void ToggleCanvas()
//     {
//         t = -t; // Toggle the value of t between 1 and -1
//         canvas.gameObject.SetActive(t == 1);
//     }
// }
