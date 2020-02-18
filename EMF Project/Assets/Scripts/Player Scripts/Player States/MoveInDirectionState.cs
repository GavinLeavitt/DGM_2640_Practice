using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveInDirectionState : IState
{
    private PlayerController owner;

    public MoveInDirectionState(PlayerController owner)
    {
        this.owner = owner;
    }
    public void Enter()
    {
        Debug.Log("entering move in direction state");
    }

    public void Execute()
    {
        owner.moveDirection = owner.magnetRotationObj.positionVector;
        owner.characterController.Move(Time.deltaTime*owner.speed*owner.moveDirection);
        if (!owner.magnetizeObj.thisBool)
        {
            owner.stateMachine.ChangeState(new AxisMoveState(owner));
        }
    }

    public void Exit()
    {
        Debug.Log("exiting move in direction state");
    }
}
