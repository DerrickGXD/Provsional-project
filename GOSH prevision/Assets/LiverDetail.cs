using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiverDetail : MonoBehaviour {

    Rigidbody liver;
    public Text liverDetail;
    private float mass = 0;
    private float hemangioma = 0;
    private float FNH = 0;
    private float hepatocellular = 0;
    private float currentlivermass = 0;
	// Use this for initialization
	void Start () {
        liver = this.gameObject.GetComponent<Rigidbody>();
        currentlivermass = liver.mass;
        setText();
	}
	
	// Update is called once per frame
	void Update () {
        liver = this.gameObject.GetComponent<Rigidbody>();
        if (liver.mass != currentlivermass)
        {
            currentlivermass = liver.mass;
            setText();
        }
	}

    public void setText()
    {
      
        hemangioma = 5 * Random.value;
        FNH = 5 * Random.value;
        hepatocellular = 5 * Random.value;
        liverDetail.text = "Cancerous Cells In Section\n\n" + "Hemangioma: " + hemangioma + " mg\n" + "FNH: " + FNH + " mg\n" + "Hepatocellular: " + hepatocellular + " mg";
    }
}
