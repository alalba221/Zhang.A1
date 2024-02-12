using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("c"))
        {
            
            Camera cam = GameObject.Find("Camera").GetComponent<Camera>();

            cam.enabled = !cam.enabled;
                
        }
    }
}
