using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Dash_Mech : MonoBehaviour
{
    public float dashDistance = 25f;        //Distance needs tuned
    public bool dashKeyWasPressed;          //Dash key is space
    public class BasicMovement: MonoBehaviour; //Need to figure out how to call this script to access these variables.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.LogFormat("I pressed space, you son of a bitch");
            dashKeyWasPressed = true;
        }
    }

    void FixedUpdate()  // Fixed update is called at a regular interval, unless specified, 50 fps for desktop computers
    {
        if (dashKeyWasPressed)
        {
            positionChange.x = Input.GetAxisRaw("Horizontal")*dashDistance;
            positionChange.y = Input.GetAxisRaw("Vertical")*dashDistance;
            dashKeyWasPressed = false;
        }
    }
}
