using UnityEngine;
using System.Collections;

public class PlayerPickup : MonoBehaviour
{
    private bool grabObj = false;
    private RaycastHit hit;
    private Vector3 mouseRot;
    private bool rotate = false;

    public int grabLength = 5;
    public float rotateSpeed = 1.0f;
    public MouseLook m1;
    public MouseLook m2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            float h = rotateSpeed * Input.GetAxis("Mouse X");
            float v = rotateSpeed * Input.GetAxis("Mouse Y");

            hit.transform.Rotate(v, h, 0, Space.World);
            print("Rotating!");

        }

        
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, grabLength))
            {
                grabObj = true;
                hit.transform.parent = gameObject.transform;
                print("PICKUP!");
            }
            else
            {
                print("No Object!");
            }

        }
        if (Input.GetKeyDown("space") && grabObj == true)
        {
         // hit.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotateSpeed);
            //hit.transform.Rotate((Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime), (Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime), 0, Space.Self);
            rotate = true;
            //Component look = playerController.GetComponent("MouseLook");
            m1.enabled = false;
            m2.enabled = false;
        }
        if (Input.GetKeyUp("space"))
        {
            rotate = false;
            m1.enabled = true;
            m2.enabled = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (grabObj)
            {
                grabObj = false;
                hit.transform.parent = null;
                print("Dropped!");
            }
        }

    }

}



