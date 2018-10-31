using UnityEngine;
using UnityEngine.SceneManagement;


namespace BzKovSoft.ObjectSlicerSamples
{
	public class MoveCamera : MonoBehaviour
	{
		public float TurnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis
		public float MoveSpeed = 4.0f;      // Speed of the camera going back and forth

		private float yaw = 0f;
		private float pitch = 0f;
        public GameObject cameraRotator;
        public static int mouseMode = 0;

        void Update()
		{
			var camera = Camera.main.gameObject.transform;
			Vector3 move = Vector3.zero;
            Vector3 relativePos = camera.position;


            transform.Rotate(0.0f, -Input.GetAxis("Horizontal") * 1, 0.0f);
            if (Input.GetKey(KeyCode.W))
				move += MoveSpeed / 100f * Vector3.forward;
			if (Input.GetKey(KeyCode.S))
				move += MoveSpeed / 100f * Vector3.back;
			if (Input.GetKey(KeyCode.A))
				move += MoveSpeed / 100f * Vector3.left;
			if (Input.GetKey(KeyCode.D))
				move += MoveSpeed / 100f * Vector3.right;
			if (Input.GetKey(KeyCode.Q))
				move += MoveSpeed / 100f * Vector3.up;
			if (Input.GetKey(KeyCode.E))
				move += MoveSpeed / 100f * Vector3.down;
            if (Input.GetKey(KeyCode.F)){
                cameraRotator.transform.Rotate(0,1,0);
            }
            if (Input.GetKey(KeyCode.H))
            {
                cameraRotator.transform.Rotate(0, -1, 0);
            }
            if (Input.GetKey(KeyCode.T))
            {
                cameraRotator.transform.Rotate(1, 0, 0);
            }
            if (Input.GetKey(KeyCode.G))
            {
                cameraRotator.transform.Rotate(-1, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftShift))
				move *= 5;

            if (Input.GetKey(KeyCode.Escape))
            {
                WriteText.canvasTextString = "";
                WriteText.instructionTextString = "";
                ChangeSprite.colorcode = 0;
           
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                
                if(mouseMode == 0)
                {
                    mouseMode = 1;
                    mouseDrag.mouseMode = 1;
                }
                else
                {
                    mouseMode = 0;
                    mouseDrag.mouseMode = 0;
                }


               
            }


			if (Mathf.Abs(move.sqrMagnitude) > Mathf.Epsilon)
				camera.Translate(move, Space.Self);

			if (Input.GetMouseButton(1))
			{
				yaw += Input.GetAxis("Mouse X");
				pitch -= Input.GetAxis("Mouse Y");
				camera.eulerAngles = new Vector3(TurnSpeed * pitch, TurnSpeed * yaw, 0.0f);
			}
		}
	}
}