using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {

    private Menu scaleMenu;
    private float scale;
    
	// Use this for initialization
	void Start () 
    {

        scaleMenu = (Menu)GameObject.Find("Director").GetComponent(typeof(Menu));
        
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        scale = scaleMenu.getScale();
        transform.localScale = new Vector3(scale, scale, scale);
	}
}
