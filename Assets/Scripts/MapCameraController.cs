using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float minFOV = 1;
    public float maxFOV = 110;
    public float sensitivity = 100;
    public float FOV = 57;

    void start(){

    }
    void Update()
    {
        FOV = Camera.main.fieldOfView;
        FOV += (Input.GetAxis("Mouse ScrollWheel") * sensitivity) * -1;
        FOV= Mathf.Clamp(FOV, minFOV, maxFOV);
        Camera.main.fieldOfView = FOV;
    }
    
}
