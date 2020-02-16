using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 1.0f;
    public float gravity = 20.0f;
    public Vector3 moveDirection = Vector3.zero;
    public StateMachine stateMachine = new StateMachine();
    // Direction for move in direction state
    public PositionData magnetRotationObj;
    public BoolData magnetizeObj;

    private void Start()
    {
        stateMachine.ChangeState(new AxisMoveState(this));
    }

    private void Update()
    {
        stateMachine.Update();
    }
}