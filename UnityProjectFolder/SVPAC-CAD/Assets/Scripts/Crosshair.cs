using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

    public Texture2D crosshairImg;
    public float crosshairSize = 1f; //used as a percentage, default is 1

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        //Sets starting location for Crosshair
        float xMin = (Screen.width / 2) - (crosshairImg.width / 2 * crosshairSize); 
        float yMin = (Screen.height / 2) - (crosshairImg.height / 2 * crosshairSize);

        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImg.width * crosshairSize, crosshairImg.height * crosshairSize), crosshairImg);
    }
}
