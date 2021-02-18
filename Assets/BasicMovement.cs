using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float moveSpeed = 5f;            //Movement speed needs tuned 
    public Rigidbody2D PC; //= 0;           //Player character
    public Vector2 positionChange;          //= transform.position;  -- no need to transform the position of the sprite since we will actually be modifying the position of the player character with the RigidBody2D component
    public float dashDistance = 25f;        //Distance needs tuned
    public bool dashKeyWasPressed;          //Dash key is space

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          //  Debug.LogFormat("I pressed space, you son of a bitch");
            dashKeyWasPressed = true;
        }
        else
        {
            positionChange.y = Input.GetAxis("Vertical");
            positionChange.x = Input.GetAxis("Horizontal");
        }
    }

    // Fixed update is called at a regular interval, unless specified, 50 fps for desktop computers
    void FixedUpdate()
    {
        //positionChange = (Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")); 
        if (dashKeyWasPressed)
            {
                positionChange.x = Input.GetAxisRaw("Horizontal")*dashDistance;
                positionChange.y = Input.GetAxisRaw("Vertical")*dashDistance;
                dashKeyWasPressed = false;
            }
        PC.position = (PC.position + positionChange * moveSpeed * Time.deltaTime); //having move speed as a public variable means that we can modify it in other scripts and make the movement a little more interactive
    }
}