﻿using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour
{

	public bool lockCursor;
	public float mouseSensitivity = 10;
	Transform target;
	public float dstFromTarget = 2;
	public Vector2 pitchMinMax = new Vector2(-40, 85);

	public float rotationSmoothTime = .12f;
	Vector3 rotationSmoothVelocity;
	Vector3 currentRotation;

	float yaw;
	float pitch;

	void Start()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	void LateUpdate()
	{
		GameObject player = GameObject.FindWithTag("Player");
		target = player.transform;

		yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
		pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

		currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
		transform.eulerAngles = currentRotation;

		transform.position = target.position - transform.forward * dstFromTarget;

	}

	public void CursorReset()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

}