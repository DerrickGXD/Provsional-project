using UnityEngine;
using BzKovSoft.ObjectSlicer;
using System.Diagnostics;
using System;
using System.Collections;
using UnityEngine.UI;

namespace BzKovSoft.ObjectSlicerSamples
{
	/// <summary>
	/// Test class for demonstration purpose
	/// </summary>
	public class SampleKnifeSlicer : MonoBehaviour
	{
#pragma warning disable 0649
		[SerializeField]
		private GameObject _blade;
#pragma warning restore 0649
        public static int cutID = 1;

        public static int cutSpeed = 50;
        public Text knifeText;

        void Update()
		{
            if (Input.GetKey(KeyCode.Alpha1))
                cutID = 1;
            if (Input.GetKey(KeyCode.Alpha2))
                cutID = 2;
            if (Input.GetKey(KeyCode.Alpha3))
                cutID = 3;
            if (Input.GetKey(KeyCode.Alpha4))
                cutID = 4;
            if (Input.GetKey(KeyCode.Alpha5))
                cutID = 5;
            if (Input.GetKey(KeyCode.Alpha6))
                cutID = 6;
            

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                cutSpeed += 1;
                if (cutSpeed > 100)
                    cutSpeed = 100;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                cutSpeed -= 1;
                if (cutSpeed < 0)
                    cutSpeed = 0;
            }

            if(knifeText!= null)
                knifeText.text = "Knife Speed: " + cutSpeed;



            if (Input.GetKey(KeyCode.Space))
			{
				var knife = _blade.GetComponentInChildren<BzKnife>();
				knife.BeginNewSlice();

				StartCoroutine(SwingSword(cutID));
			}
		}

		IEnumerator SwingSword(int cutID)
		{
			var transformB = _blade.transform;
			transformB.position = Camera.main.transform.position;
			transformB.rotation = Camera.main.transform.rotation;

			float seconds = 100.0f / cutSpeed;
			for (float f = 0f; f < seconds; f += Time.deltaTime)
			{
				float aY = (f / seconds) * 180 - 90;
				float aX = (f / seconds) * 60 - 30;
                //float aX = 0;
                
                var r = Quaternion.Euler(0, 0, 0);

                if(cutID == 1)
				     r = Quaternion.Euler(aX, 0, aY);
                if (cutID == 2)
                    r = Quaternion.Euler(-aX, 0, -aY);
                if (cutID == 3)
                    r = Quaternion.Euler(aX, aY, 0);
                if (cutID == 4)
                    r = Quaternion.Euler(aX, -aY, 0);
                if (cutID == 5)
                    r = Quaternion.Euler(0, aX, aY);
                if (cutID == 6)
                    r = Quaternion.Euler(0, -aX, -aY);

                transformB.rotation = Camera.main.transform.rotation * r;
				yield return null;
			}
		}
	}
}