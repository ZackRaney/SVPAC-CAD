using UnityEngine;
using System.Collections;

public class PlayerPickup : MonoBehaviour
{
    private bool grabObj = false;
    private RaycastHit hit;
    private Vector3 mouseRot;
    private bool rotate = false; 
    private bool mouseLookEnabled = true;

    public int grabLength = 5; //Sets the max grab distance
    public float rotateSpeed = 1.0f; //Changes the speed that the mouse rotates the object
    //sets the two MouseLook objects; **must be set in inspector**
    public MouseLook m1;
    public MouseLook m2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rotate) //if space was pressed last frame
        {
            //gets mouse position
            float h = rotateSpeed * Input.GetAxis("Mouse X");
            float v = rotateSpeed * Input.GetAxis("Mouse Y");

            //rotates the object that was hit relative to world axis
            hit.transform.Rotate(v, h, 0, Space.World);
            print("Rotating!");

        }

        
        if (Input.GetMouseButtonDown(0))
        {
            //casts ray when space is pressed
            if (Physics.Raycast(transform.position, transform.forward, out hit, grabLength)) 
            {
                //Ray hit an object
                grabObj = true;
                hit.transform.parent = gameObject.transform; //parents the hit object to the camera
                print("PICKUP!");
            }
            else
            {
                //Ray didnt find anything
                print("No Object!");
            }

        }
        if (Input.GetKeyDown("space") && grabObj == true)
        {
            //activates the rotate if statement at the start of the next frame
            rotate = true;
            //disable mouselook on both capsule and camera
            DisableMouselook();
        }
        if (Input.GetKeyUp("space"))
        {
            //when space is released 
            rotate = false;
            EnableMouselook();
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (grabObj)
            {
                //When mouse button is released and there is a grabbed object
                grabObj = false;
                hit.transform.parent = null;
                print("Dropped!");
            }
        }
        //code for disableing mouselook to interact with menus 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //if mouse isnt alread disabled
            if (mouseLookEnabled)
            {
                DisableMouselook();
                mouseLookEnabled = false;
            }
            else
            {
                EnableMouselook();
                mouseLookEnabled = true;
            }
        }

    }

    void DisableMouselook()
    {
        m1.enabled = false;
        m2.enabled = false;
    }
    void EnableMouselook()
    {
        m1.enabled = true;
        m2.enabled = true;
    }

}



