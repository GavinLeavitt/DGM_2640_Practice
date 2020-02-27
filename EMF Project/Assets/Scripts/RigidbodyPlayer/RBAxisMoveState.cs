using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBAxisMoveState : IState
{
	private RBPlayerController owner;

	public RBAxisMoveState(RBPlayerController owner)
	{
		this.owner = owner;
	}

	public void Enter()
	{
		Debug.Log("entering move state");
		owner.playerBody.useGravity = true;
	}

	public void Execute()
	{
		// Get direction from input axes
		owner.moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		owner.moveDirection *= owner.speed;

		// Move the Rigidbody
		owner.playerBody.MovePosition(owner.playerBody.position + owner.moveDirection*Time.deltaTime);

		if (owner.magnetizeObj.thisBool)
		{
			owner.stateMachine.ChangeState(new RBMoveInDirectionState(owner));
		}
	}

	public void Exit()
	{
		Debug.Log("exiting move state");
	}
}
