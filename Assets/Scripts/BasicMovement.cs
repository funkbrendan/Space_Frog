using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float moveSpeed = 5f;            //Movement speed needs tuned 
    Rigidbody2D PC;     //Player character
    public Vector2 positionChange;                       //= transform.position;  -- no need to transform the position of the sprite since we will actually be modifying the position of the player character with the RigidBody2D component

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        positionChange.y = Input.GetAxis("Vertical");
        positionChange.x = Input.GetAxis("Horizontal");

        //code graveyard
        //transform.position = position; -- couldn't figure out why, but this gave me a blue screen for some reason?

    }

    // Fixed update is called at a regular interval, unless specified, 50 fps for desktop computers
    void FixedUpdate()
    {
        /*position.x*/PC.position = PC.position + positionChange * /*3.0f*/moveSpeed /** horizontal*/ * Time.deltaTime; //having move speed as a public variable means that we can modify it in other scripts and make the movement a little more interactive
      //  /*position.y*/PlayerCharacter.position = position.y + /*3.0f*/ moveSpeed * vertical * Time.deltaTime; //only need one since the rigidbody2d class has both an x and a y and so does our position vector
    }
}