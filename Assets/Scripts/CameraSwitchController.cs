using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchController : MonoBehaviour
{
    public GameObject mapCamera;
    public GameObject playerCamera;

    bool isPlayerCameraOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            if(isPlayerCameraOn){
                playerCamera.SetActive(false);
                mapCamera.SetActive(true);
                isPlayerCameraOn = false;
            }
            else{
                playerCamera.SetActive(true);
                mapCamera.SetActive(false);
                isPlayerCameraOn = true;
            }
        }
    }
}
