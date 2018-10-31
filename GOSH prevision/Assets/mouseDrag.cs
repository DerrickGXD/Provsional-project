using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDrag : MonoBehaviour {

    float zpos = 0f;
    public static int mouseMode = 0;
    public GameObject liverDetail;
    public static bool switching = false;
    
    private void Start()
    {
        zpos = transform.position.z;
        liverDetail.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {

            liverDetail.SetActive(false);
        }
    }

  

    public void OnMouseEnter()
    {
        if(mouseMode == 1)
        {
            liverDetail.SetActive(true);
        }
    }

    public void OnMouseExit()
    {
        if (mouseMode == 1)
        {
            liverDetail.SetActive(false);
        }
    }




    public void OnMouseDrag()
    {
        if (mouseMode == 0)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zpos);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;
            EmissionOnDrag.onDrag = true;
            if (objectPosition.x > -4.2 && objectPosition.x < -1.8 && objectPosition.y > 1 && objectPosition.y < 2.5 && objectPosition.z > 0.5 && objectPosition.z < 1.5)
            {
                EmissionOnDrag.onTable = true;
            }
            else
            {
                EmissionOnDrag.onTable = false;
            }
        }

    }

    public void OnMouseUp()
    {
        if(mouseMode == 0)
        {
            EmissionOnDrag.onDrag = false;
        }
        
    }

}
