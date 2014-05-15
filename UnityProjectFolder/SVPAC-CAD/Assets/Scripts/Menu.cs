using UnityEngine;
using System.Collections;


public class Menu : MonoBehaviour {

    public float scale = 1;
    private string scaleString = "1";
    private float clipping = .01f;
    private string clippingString = ".01";


    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 150, 200), "Menu"); //Creates the box for the menu
        if (GUI.Button(new Rect(20, 40, 130, 20), "Reset Scene")) //creates a button labled "Reset" in the menu
        {
            //Loads the first level in the build options list. Make sure this is set to the correct scene
            Application.LoadLevel(0);  
        }
        if (GUI.Button(new Rect(20, 110, 130, 20), "Apply Scale"))
        {
            scale = System.Convert.ToSingle(scaleString);
        }
        scaleString = GUI.TextField(new Rect(20, 80, 130, 20),scaleString);


        GUI.Label(new Rect(20, 140, 130, 25), "Clipping Range");

        clipping = GUI.HorizontalSlider(new Rect(20, 165, 130, 20), clipping, .01f, 20f);

        Camera.main.nearClipPlane = clipping;
    }

    public float getScale()
    {
        return scale;
    }


}
