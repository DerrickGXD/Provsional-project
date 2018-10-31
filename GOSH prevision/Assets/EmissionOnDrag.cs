using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionOnDrag : MonoBehaviour {

    public static bool onDrag = false;
    public Material material;
    public static bool onTable = true;
    public static bool onDragMode = true;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (onDragMode)
        {
            if (onDrag)
            {
                if (onTable)
                {
                    if (material != null)
                        material.SetColor("_EmissionColor", Color.green);
                }
                else
                {
                    if (material != null)
                        material.SetColor("_EmissionColor", Color.red);
                }

            }
            else
            {
                if (material != null)
                    material.SetColor("_EmissionColor", Color.black);
            }
        }
        else
        {
            material.SetColor("_EmissionColor", Color.black);
        }

	}
}
