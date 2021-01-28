using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;



public class Dash_Mech : MonoBehaviour
{
    public float dashDistance = 25f;        //Distance needs tuned
    public bool dashKeyWasPressed;       //Dash key is space
    public Vector2 bigDash;
    public Rigidbody2D PC;
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

        //Since they are acting on the same GameObject you can grab the component like I did below. I just name PC the same thing with a rigidbody, that may be a conflict.
        //Watch video so you can see. It "technically" works, but not really.
    {
        if (dashKeyWasPressed)
        {
            PC = gameObject.GetComponent<BasicMovement>().PC;
            bigDash = PC.position * dashDistance;
            dashKeyWasPressed = false;
        }
    }
}
