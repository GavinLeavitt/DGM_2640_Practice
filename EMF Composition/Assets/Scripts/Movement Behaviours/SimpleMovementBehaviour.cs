using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SimpleMovementBehaviour : MonoBehaviour {

	public Rigidbody bodyObj;
	public float moveSpeed = 10.0f;
	private Vector3 direction;

	private void Awake()
	{
		bodyObj = GetComponent<Rigidbody>();
		direction = bodyObj.rotation * Vector3.forward;
	}

	public void AxisMove()
	{
		var mouseCheck = 1.0f - Mathf.Abs(Input.GetAxis("Mouse Button Axis"));
		var axisDirection = new Vector3(Input.GetAxis("Horizontal")*mouseCheck, 0.0f, Input.GetAxis("Vertical")*mouseCheck);
		if ((Physics.gravity.y - bodyObj.velocity.y) > -7.2f) return;
		bodyObj.MovePosition(bodyObj.position + axisDirection * moveSpeed * Time.deltaTime);
	}

	public void MoveInDirection()
	{
		bodyObj.MovePosition(bodyObj.position + direction * moveSpeed * Time.deltaTime);
	}

	public void SetNewPosition(Transform transform)
	{
		bodyObj.position = transform.position;
	}

	public void ChangeSpeed(float newSpeed)
	{
		moveSpeed = newSpeed;
	}

	public void ChangeDirection(Vector3 newVector)
	{
		direction = newVector;
	}
}
