using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisMoveState : IState
{
	private PlayerController owner;

	public AxisMoveState(PlayerController owner)
	{
		this.owner = owner;
	}

	public void Enter()
	{
		Debug.Log("entering move state");
	}

	public void Execute()
	{
		if (owner.characterController.isGrounded) {
			// Get direction from input axes if grounded
			owner.moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
			owner.moveDirection *= owner.speed;
		}

		// Apply gravity
		owner.moveDirection.y -= owner.gravity * Time.deltaTime;

		// Move the controller
		owner.characterController.Move(owner.moveDirection*Time.deltaTime);

		if (owner.magnetizeObj.thisBool)
		{
			owner.stateMachine.ChangeState(new MoveInDirectionState(owner));
		}
	}

	public void Exit()
	{
		Debug.Log("exiting move state");
	}
}
