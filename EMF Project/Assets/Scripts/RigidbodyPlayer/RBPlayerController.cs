using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBPlayerController : MonoBehaviour
{
    public Rigidbody playerBody;
    public float speed = 1.0f;
    public Vector3 moveDirection = Vector3.zero;
    public StateMachine stateMachine = new StateMachine();
    // Direction for move in direction state
    public PositionData magnetRotationObj;
    public BoolData magnetizeObj;

    private void Start()
    {
        stateMachine.ChangeState(new RBAxisMoveState(this));
    }

    private void Update()
    {
        stateMachine.Update();
    }
}