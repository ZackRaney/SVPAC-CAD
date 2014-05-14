using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    public float scale = 1;

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 150, 80), "Menu"); //Creates the box for the menu
        if (GUI.Button(new Rect(20, 40, 130, 20), "Reset")) //creates a button labled "Reset" in the menu
        {
            //Loads the first level in the build options list. Make sure this is set to the correct scene
            Application.LoadLevel(0);  
        }
    }
}
