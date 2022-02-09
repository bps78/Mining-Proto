//Fixed the issues with the previous controller
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsRotation : MonoBehaviour
{
	public float minX = -60f;
	public float maxX = 60f;

	public float sensitivity;
	public Camera cam;

	public float rotY = 0f;
	public float rotX = 0f;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void LateUpdate()
	{
		rotY += Input.GetAxis("Mouse X") * sensitivity;
		rotX += Input.GetAxis("Mouse Y") * sensitivity;

		rotX = Mathf.Clamp(rotX, minX, maxX);

		
		transform.localEulerAngles = new Vector3(-rotX, rotY, 0);

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		if (Cursor.visible && Input.GetMouseButtonDown(1))
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
	}
}