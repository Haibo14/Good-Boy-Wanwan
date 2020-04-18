using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public float walkSpeed = 2;
	public float runSpeed = 6;

	public float turnSmoothTime = 0.2f;
	float turnSmoothVelocity;

	public float speedSmoothTime = 0.1f;
	float speedSmoothVelocity;
	float currentSpeed;
	public TextMesh DeathText;


	Transform cameraT;

	void Start()
	{
	
		cameraT = Camera.main.transform;
	}

	void Update()
	{

		Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		Vector2 inputDir = input.normalized;

		if (inputDir != Vector2.zero)
		{
			float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraT.eulerAngles.y;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
		}

		bool running = Input.GetKey(KeyCode.LeftShift);
		float targetSpeed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
		currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

		transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);


	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Car")){
			DeathText.text = "YOU ARE ALREADY DEAD";
			Destroy(DeathText, 5.0f);
			//Destroy(this.gameObject, 5.0f);
		}
	}
}