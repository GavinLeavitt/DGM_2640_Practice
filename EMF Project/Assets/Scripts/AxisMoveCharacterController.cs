using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class AxisMoveCharacterController : MonoBehaviour 
{
	public CharacterController characterController;
	public float speed = 1.0f;
	public float gravity = 20.0f;
	private Vector3 moveDirection = Vector3.zero;

	void Start () {
		characterController = GetComponent<CharacterController>();
	}
	
	void Update () {
		if (characterController.isGrounded) {
			// Get direction from input axes if grounded
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
			moveDirection *= speed;
		}

		//Apply gravity
		moveDirection.y -= gravity * Time.deltaTime;

		// Move the controller
		characterController.Move(moveDirection*Time.deltaTime);
	}

	
}
