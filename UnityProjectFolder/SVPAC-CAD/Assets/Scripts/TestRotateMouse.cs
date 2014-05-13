using UnityEngine;
using System.Collections;

public class TestRotateMouse : MonoBehaviour {

    public float rotateSpeed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float h = rotateSpeed * Input.GetAxis("Mouse X");
        float v = rotateSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0, Space.World);
	}
}
