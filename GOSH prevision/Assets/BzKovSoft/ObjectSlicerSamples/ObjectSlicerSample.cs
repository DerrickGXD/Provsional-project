using BzKovSoft.ObjectSlicer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace BzKovSoft.ObjectSlicerSamples
{
	public class ObjectSlicerSample : BzSliceableObjectBase
	{
        public Text knifeSpeedUI;
        public Image panel;
		protected override BzSliceTryData PrepareData(Plane plane)
		{
			// remember some data. Later we could use it after the slice is done.
			// here I add Stopwatch object to see how much time it takes
			// and vertex count to display.
			ResultData addData = new ResultData();

			// count vertices
			var filters = GetComponentsInChildren<MeshFilter>();
			for (int i = 0; i < filters.Length; i++)
			{
				addData.vertexCount += filters[i].sharedMesh.vertexCount;
			}

			// remember start time
			addData.stopwatch = Stopwatch.StartNew();

			// colliders that will be participating in slicing
			var colliders = gameObject.GetComponentsInChildren<Collider>();

			// return data
			return new BzSliceTryData()
			{
				// componentManager: this class will manage components on sliced objects
				componentManager = new StaticComponentManager(gameObject, plane, colliders),
				plane = plane,
				addData = addData,
			};
		}

		protected override void OnSliceFinished(BzSliceTryResult result)
		{
			if (!result.sliced)
				return;

            // on sliced, get data that we saved in 'PrepareData' method
            int lowEnd = UnityEngine.Random.Range(10,60);
            int highEnd = lowEnd + 30;
            string comment = "";

            if(SampleKnifeSlicer.cutSpeed>= lowEnd && SampleKnifeSlicer.cutSpeed <= highEnd)
            {
                ChangeSprite.colorcode = 1;
                panel.color = new Color(0.0f / 255, 232.0f / 255, 34.0f / 255, 100.0f/255);
                comment = "GOOD SPEED :)";
                knifeSpeedUI.color = new Color(0.0f/255,232.0f/255,34.0f/255);
            }
            else
            {
                if (SampleKnifeSlicer.cutSpeed < lowEnd)
                {
                    ChangeSprite.colorcode = 2;
                    panel.color = new Color(255.0f / 255, 10.0f / 255, 10.0f / 255, 100.0f / 255);
                    comment = "TOO SLOW :(";
                    knifeSpeedUI.color = new Color(255.0f/255,10.0f/255,10.0f/255);
                }
                else
                {
                    ChangeSprite.colorcode = 3;
                    panel.color = new Color(106.0f / 255, 163.0f / 255, 255.0f / 255, 100.0f / 255);
                    comment = "TOO FAST :(";
                    knifeSpeedUI.color = new Color(106.0f/255,163.0f/255,255.0f/255);
                }
            }

            

            string optimumSpeed = lowEnd + "-" + highEnd;
            WriteText.fontSize = 4;
            WriteText.canvasTextString = comment + "\n\n"+"KNIFE SPEED: "+ SampleKnifeSlicer.cutSpeed + "\n" + "OPTIMUM SPEED: "+optimumSpeed;
            
            var addData = (ResultData)result.addData;
            slicenumber += 1;
			addData.stopwatch.Stop();
            String[] cutType = new string[] { "Downwards", "Upwards", "Right Down", "Left Down", "Rightwards", "Leftwards" };
            
            drawText += "Slice Type: " + cutType[SampleKnifeSlicer.cutID-1] +
				". Slice Number: " + slicenumber + ". Pressure: " +
				(SampleKnifeSlicer.cutSpeed*0.5256f) +'\n';
         
			if(drawText.Split('\n').Length > 4)
            {
                drawText = drawText.Substring(drawText.IndexOf('\n') + 1);
            }
		}

        static int cutID;
        static int slicenumber = 0;
		static string drawText = "";

		void OnGUI()
		{
            GUI.contentColor = Color.black;
            GUI.Label(new Rect(10, 10, 2000, 2000), drawText);
		}

		// DTO that we pass to slicer and then receive back
		class ResultData
		{
			public int vertexCount;
			public Stopwatch stopwatch;
		}
	}
}
