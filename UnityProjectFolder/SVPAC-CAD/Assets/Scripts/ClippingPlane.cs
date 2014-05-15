using UnityEngine;
using System.Collections;

public class ClippingPlane : MonoBehaviour
{
    private float clipping = .01f;
    private string clippingString;

    void OnGUI()
    {
        if (GUI.Button(new Rect(20, 180, 130, 20), "Clipping Plane"))
        {
            clipping = System.Convert.ToSingle(clippingString);
        }
        clippingString = GUI.TextField(new Rect(20, 150, 130, 20), clippingString);

       Camera.main.nearClipPlane = clipping;
    }

}
