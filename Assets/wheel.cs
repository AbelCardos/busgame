using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject steeringWheel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion currentRotation = steeringWheel.transform.rotation;
            steeringWheel.transform.Rotate(0, 0, 1.5f);

        }
        if(Input.GetKey(KeyCode.A)) {

            Quaternion currentRotation = steeringWheel.transform.rotation;
            steeringWheel.transform.Rotate(0, 0, -1.5f);

        }
    }


}

