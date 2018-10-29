using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class WriteText : MonoBehaviour {

    public Text canvasText, instructionText;
    public string canvasTextString = "";
    public string instructionTextString = "";
    public GameObject instructionCanvas;
    public string stringwelcomefirst = "WELCOME TO SURGEON SIMULATOR 2K18";
    public string instruction = "CLICK ON THE HELP BUTTON FOR INSTRUCTIONS";
    public string[] welcomeArr;

	// Use this for initialization
	void Start () {
        StartCoroutine(incrementText(stringwelcomefirst, 0, true));
        instructionCanvas.SetActive(false);
        StartCoroutine(showInstruction());

	}
	
	// Update is called once per frame
	void Update () {
        if(canvasText!=null)
            canvasText.text = canvasTextString;
        if(instructionText!=null)
            instructionText.text = instructionTextString;
	}

    IEnumerator showInstruction()
    {
        yield return new WaitForSeconds(3f);
        instructionCanvas.SetActive(true);
        StartCoroutine(incrementText(instruction, 1, true));
    }

    IEnumerator incrementText(string stringwelcome, int canvasID, bool newLine)
    {
       
        var welcomeArr = stringwelcome.Split(' ');
        for (var i = 0; i < welcomeArr.Length; i++)
        {
            for(var j = 0; j < welcomeArr[i].Length; j++)
            {
                if(canvasID == 0)
                {
                    canvasTextString += welcomeArr[i][j];
                }
                else
                {
                    instructionTextString += welcomeArr[i][j];
                }
                
                yield return new WaitForSeconds(0.05f);
            }
            if (newLine)
            {
                if (canvasID == 0)
                {
                    if (welcomeArr.Length - i > 1)
                        canvasTextString += "\n";
                }
                else
                {
                    if (welcomeArr.Length - i > 1)
                        instructionTextString += "\n";
                }
                
            }
            
            yield return new WaitForSeconds(0.05f);
        }

    }


}
