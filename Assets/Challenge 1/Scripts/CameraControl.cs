using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    public Camera rearCamera;
    public Camera mainCamera;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        rearCamera.enabled = false;
        mainCamera.enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetKey(KeyCode.B))
        {
            rearCamera.enabled = true;
            mainCamera.enabled = false;
        }
        else
        {
            rearCamera.enabled = false;
            mainCamera.enabled = true;
        }
        
        
        
    }
}
