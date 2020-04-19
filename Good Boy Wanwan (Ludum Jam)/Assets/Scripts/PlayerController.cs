﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private Animator PatteAvGAnimator;
	[SerializeField] private Animator PatteAvDAnimator;
	[SerializeField] private Animator PatteArGAnimator;
	[SerializeField] private Animator PatteArDAnimator;

	public float walkSpeed = 2;
	public float runSpeed = 6;

	public float turnSmoothTime = 0.2f;
	float turnSmoothVelocity;

	public float speedSmoothTime = 0.1f;
	float speedSmoothVelocity;
	float currentSpeed;
	public TextMesh DeathText;

	int state;
	

	Transform cameraT;

	void Start()
	{
		cameraT = Camera.main.transform;

		

		state = 0;
	}

	void Update()
	{

		Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		Vector2 inputDir = input.normalized;

		if (inputDir != Vector2.zero)
		{
			float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraT.eulerAngles.y;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);

			state = 1;

		} else{
			state = 0;

		}

		bool running = Input.GetKey(KeyCode.LeftShift);
		float targetSpeed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
		currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

		transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);

		if (running == true)
		{
			state = 2;
		}

		PatteAvGAnimator.SetInteger("State", state);
		PatteArGAnimator.SetInteger("State", state);
		PatteAvDAnimator.SetInteger("State", state);
		PatteArDAnimator.SetInteger("State", state);
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Car")){
			DeathText.text = "YOU ARE ALREADY DEAD";
			Destroy(DeathText, 5.0f);
			//Destroy(this.gameObject, 5.0f);
		}
	}
}