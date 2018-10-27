using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour {

    public Sprite s1, s2, s3, s4, s5, s6;
	// Use this for initialization
	void Start () {
        this.GetComponent<Image>().sprite = s1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha1))
            this.GetComponent<Image>().sprite = s1;
        if (Input.GetKey(KeyCode.Alpha2))
            this.GetComponent<Image>().sprite = s2;
        if (Input.GetKey(KeyCode.Alpha3))
            this.GetComponent<Image>().sprite = s3;
        if (Input.GetKey(KeyCode.Alpha4))
            this.GetComponent<Image>().sprite = s4;
        if (Input.GetKey(KeyCode.Alpha5))
            this.GetComponent<Image>().sprite = s5;
        if (Input.GetKey(KeyCode.Alpha6))
            this.GetComponent<Image>().sprite = s6;
    }
}
