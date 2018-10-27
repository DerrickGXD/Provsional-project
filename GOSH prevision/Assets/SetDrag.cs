using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDrag : MonoBehaviour {

    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {
        rb.drag = rb.mass/10;
        rb.angularDrag = rb.mass/10;

    }
}
