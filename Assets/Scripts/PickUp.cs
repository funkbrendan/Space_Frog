using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    /*Comment 1
     * For picking up objects in our game. Keep in mind that you have to have the tag "Box" selected on a game object for this to work as it currently stands.
     * To find the box tag, just look right underneath the name of the gameobject in the inspector and select from the menu. Also of note: this CAN work with dynamic
     * objects, but it is a little weird. You most likely want to put them as kinematic objects if you want this to work properly. No biggie, just another dropdown menu.
     */
    public Transform grab;
    public Transform boxHolder;
    public float rayDist;

    void Update()
    {
        /*Comment 2
        *RaycastHit2D class gives us information about objects in direct line of sight. In grabbed, I taking(first vector origin, adding a direction, shooting my "ray" a certain distance)
        *At least, that is what I think. It works and I am a bit fuzzy on this still.
        */
        RaycastHit2D grabbed = Physics2D.Raycast(grab.position, Vector2.right * transform.localScale, rayDist);


        /*Comment 3
         * The GameObject must be connected to a collider. This code starts with an if statement which allows us to act on the 'grabbed' object. States that
        * if it is picked up and it has the box tag that it will act in accordance with my next comments.
        */
        if(grabbed.collider != null && grabbed.collider.tag == "Box")
        {
            /*Comment 4
             * Tells us which key we will use for this interaction. Then, it uses the transform to tell us to follow the boxHolder (the player). The second part tells us about dropping.
             */
            if (Input.GetKey(KeyCode.E))
            {
                grabbed.collider.gameObject.transform.parent = boxHolder;
                grabbed.collider.gameObject.transform.position = boxHolder.position;
            }
            if (Input.GetKey(KeyCode.G))
            {
                grabbed.collider.gameObject.transform.parent = null;
            }
        }
    }

    /*Comment 5
     * I would like to do a few things with this code. First, I want to change it so that the key for dropping and picking up is the same. I was having some issues with that and
     * decided on the above solution. Second, if you edit this code and it seems like the character is moving backwards at a fast rate or otherwise moving in a weird, wonky way, that
     * is because the colliders are too close. You need to those. Easiest way is in the current iteration is to change the transform on the 'Environment Hold' GameObject.
     */
}
