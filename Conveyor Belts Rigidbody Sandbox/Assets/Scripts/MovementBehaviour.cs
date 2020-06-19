using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementBehaviour : MonoBehaviour {

	public Rigidbody bodyObj;
	public float moveSpeed = 10.0f;
	public float slideSpeed = 5.0f;
	public Vector3 direction;
	public bool conditionalMove = false;

	private void Awake()
	{
		bodyObj = GetComponent<Rigidbody>();
		direction = Vector3.zero;
	}

	public void AxisMove()
	{
		var axisDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		bodyObj.MovePosition(bodyObj.position + axisDirection * moveSpeed * Time.deltaTime);
	}

	public void ToggleCondition(bool newBool)
	{
		conditionalMove = newBool;
	}

	public void MoveInDirection()
	{
		bodyObj.MovePosition(bodyObj.position + direction * slideSpeed * Time.deltaTime);
	}

	public void ConditionalMoveInDirection()
	{
		if (!conditionalMove) return;
		bodyObj.MovePosition(bodyObj.position + direction * slideSpeed * Time.deltaTime);
	}

	public void ChangeSlideSpeed(FloatData newSpeed)
	{
		slideSpeed = newSpeed.floatObj;
	}

	public void ChangeDirection(Vector3 newVector)
	{
		direction = newVector;
	}

	public void ChangeDirectionData(Vector3Data newVector)
	{
		direction = newVector.vectorObj;
	}
}
