using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttontointruction : MonoBehaviour, IPointerDownHandler {

    public GameObject instructionPage;


	// Use this for initialization
	void Start () {
        instructionPage.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        instructionPage.SetActive(true);
        
    }
}
