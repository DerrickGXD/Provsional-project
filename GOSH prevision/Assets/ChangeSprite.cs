using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour {

    public Sprite s1r, s1b, s1g, s1d, s2r, s2b, s2g, s2d, s3r, s3g, s3b, s3d, s4r, s4g, s4b, s4d, s5b, s5r, s5g, s5d, s6r, s6g, s6b, s6d;
    public static int colorcode = 0;
    public static int cutnumber = 0;

	// Use this for initialization
	void Start () {
        this.GetComponent<Image>().sprite = s1d;
    
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Alpha1)||cutnumber==0)
        {
            if (colorcode == 0)
                this.GetComponent<Image>().sprite = s1d;
            if (colorcode == 1)
                this.GetComponent<Image>().sprite = s1g;
            if (colorcode == 2)
                this.GetComponent<Image>().sprite = s1r;
            if (colorcode == 3)
                this.GetComponent<Image>().sprite = s1b;
            cutnumber = 0;
        }
            
        if (Input.GetKey(KeyCode.Alpha2)||cutnumber==1)
        {
            if (colorcode == 0)
                this.GetComponent<Image>().sprite = s2d;
            if (colorcode == 1)
                this.GetComponent<Image>().sprite = s2g;
            if (colorcode == 2)
                this.GetComponent<Image>().sprite = s2r;
            if (colorcode == 3)
                this.GetComponent<Image>().sprite = s2b;
            cutnumber = 1;
        }
            
        if (Input.GetKey(KeyCode.Alpha3)||cutnumber ==2)
        {
            if (colorcode == 0)
                this.GetComponent<Image>().sprite = s3d;
            if (colorcode == 1)
                this.GetComponent<Image>().sprite = s3g;
            if (colorcode == 2)
                this.GetComponent<Image>().sprite = s3r;
            if (colorcode == 3)
                this.GetComponent<Image>().sprite = s3b;
            cutnumber = 2;
        }
            
        if (Input.GetKey(KeyCode.Alpha4)||cutnumber == 3)
        {
            if (colorcode == 0)
                this.GetComponent<Image>().sprite = s4d;
            if (colorcode == 1)
                this.GetComponent<Image>().sprite = s4g;
            if (colorcode == 2)
                this.GetComponent<Image>().sprite = s4r;
            if (colorcode == 3)
                this.GetComponent<Image>().sprite = s4b;
            cutnumber = 3;
        }
           
        if (Input.GetKey(KeyCode.Alpha5)||cutnumber==4)
        {
            if (colorcode == 0)
                this.GetComponent<Image>().sprite = s5d;
            if (colorcode == 1)
                this.GetComponent<Image>().sprite = s5g;
            if (colorcode == 2)
                this.GetComponent<Image>().sprite = s5r;
            if (colorcode == 3)
                this.GetComponent<Image>().sprite = s5b;
            cutnumber = 4;
        }
            
        if (Input.GetKey(KeyCode.Alpha6)||cutnumber==5)
        {
            if (colorcode == 0)
                this.GetComponent<Image>().sprite = s6d;
            if (colorcode == 1)
                this.GetComponent<Image>().sprite = s6g;
            if (colorcode == 2)
                this.GetComponent<Image>().sprite = s6r;
            if (colorcode == 3)
                this.GetComponent<Image>().sprite = s6b;
            cutnumber = 5;
        }   

    }
}
