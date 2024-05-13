using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public bool isCamera1Selected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            //isCamera1Selected = false;
            camera1.SetActive(false);
            camera2.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        { 
            //isCamera1Selected = true;
            camera1.SetActive(true);
            camera2.SetActive(false);

        }

    }
}
