using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

    public Texture2D crosshairImg;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crosshairImg.width / 2);
        float yMin = (Screen.height / 2) - (crosshairImg.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImg.width, crosshairImg.height), crosshairImg);
    }
}
