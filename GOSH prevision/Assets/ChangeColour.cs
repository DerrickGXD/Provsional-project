using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

    public Material matofObject;
    public Color new_color;
    public KeyCode changecol;

	// Use this for initialization
	void Start () {

        matofObject.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
        matofObject.color = Color.red;
    }
}
