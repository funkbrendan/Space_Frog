using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    /*
     * For picking up objects in our game. Keep in mind that you have to have the tag "Box" selected on a game object for this to work as it currently stands.
     * To find the box tag, just look right underneath the name of the gameobject in the inspector and select from the menu. Also of note: this CAN work with dynamic
     * objects, but it is a little weird. You most likely want to put them as kinematic objects if you want this to work properly. No biggie, just another dropdown menu.
     */
    public Transform grab;
    public Transform boxHolder;
    public float rayDist;

    void Update()
    {
        //RaycastHit2D class gives us information about objects in direct line of sight. In grabbed, I taking(first vector origin, adding a direction, shooting my "ray" a certain distance)
        //At least, that is what I think. It works and I am a bit fuzzy on this still.
        RaycastHit2D grabbed = Physics2D.Raycast(grab.position, Vector2.right * transform.localScale, rayDist);


        //Done working today, will add more commentary. Current date 3/17/2021
        if(grabbed.collider != null && grabbed.collider.tag == "Box")
        {
            if (Input.GetKey(KeyCode.E))
            {
                grabbed.collider.gameObject.transform.parent = boxHolder;
                grabbed.collider.gameObject.transform.position = boxHolder.position;
            }
            else
            {
                grabbed.collider.gameObject.transform.parent = null;
            }
        }
    }
}
