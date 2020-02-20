using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RBMoveInDirectionState : IState
{
    private RBPlayerController owner;

    public RBMoveInDirectionState(RBPlayerController owner)
    {
        this.owner = owner;
    }
    public void Enter()
    {
        Debug.Log("entering move in direction state");
        owner.playerBody.useGravity = false;
    }

    public void Execute()
    {
        owner.moveDirection = owner.magnetRotationObj.positionVector;
        owner.playerBody.MovePosition(owner.playerBody.position + Time.deltaTime*owner.speed*owner.moveDirection);
        if (!owner.magnetizeObj.thisBool)
        {
            owner.stateMachine.ChangeState(new RBAxisMoveState(owner));
        }
    }

    public void Exit()
    {
        Debug.Log("exiting move in direction state");
    }
}
