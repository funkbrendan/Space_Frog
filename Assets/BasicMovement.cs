using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float moveSpeed = 5f;            //Movement speed needs tuned 
    public Rigidbody2D PC; //= 0;           //Player character
    public Vector2 positionChange;          //= transform.position;  -- no need to transform the position of the sprite since we will actually be modifying the position of the player character with the RigidBody2D component

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        positionChange.y = Input.GetAxis("Vertical");
        positionChange.x = Input.GetAxis("Horizontal");

    }

    // Fixed update is called at a regular interval, unless specified, 50 fps for desktop computers
    void FixedUpdate()
    {
       PC.position = PC.position + positionChange * moveSpeed * Time.deltaTime; //having move speed as a public variable means that we can modify it in other scripts and make the movement a little more interactive
    }
}