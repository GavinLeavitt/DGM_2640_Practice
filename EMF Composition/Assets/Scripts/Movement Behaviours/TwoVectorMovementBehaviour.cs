using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TwoVectorMovementBehaviour : MonoBehaviour {
	public Rigidbody rigidbodyObj;
	public float speed = 10.0f;

	public Vector3Data posTargetVector;
	public bool posRequireRange = true;
	public int posObjInRange = 0;

	public Vector3Data negTargetVector;
	public bool negRequireRange = true;
	public int negObjInRange = 0;

	public void Awake()
	{
		rigidbodyObj = GetComponent<Rigidbody>();
	}

	public void PosMoveTowardsVector(float direction)
	{
		if (!posRequireRange || posObjInRange > 0)
		{
			rigidbodyObj.useGravity = false;
			rigidbodyObj.MovePosition(rigidbodyObj.position - (direction * Time.deltaTime * speed * posTargetVector.value));
		} else
		{
			rigidbodyObj.useGravity = true;
		}
	}

	public void NegMoveTowardsVector(float direction)
	{
		if (!negRequireRange || negObjInRange > 0)
		{
			rigidbodyObj.useGravity = false;
			rigidbodyObj.MovePosition(rigidbodyObj.position - (direction * Time.deltaTime * speed * negTargetVector.value));
		} else
		{
			rigidbodyObj.useGravity = true;
		}
	}

	public void ClearRange()
	{
		posObjInRange = 0;
		negObjInRange = 0;
	}

	public void IncrementRange(bool positive)
	{
		if (positive)
		{
			posObjInRange ++;
		} 
		else
		{
			negObjInRange ++;
		}
	}

	public void DecrementRange(bool positive)
	{
		if (positive)
		{
			if (posObjInRange >= 0) posObjInRange --;
			if (posObjInRange < 0) posObjInRange = 0;
		} 
		else
		{
			if (negObjInRange >= 0) negObjInRange --;
			if (negObjInRange < 0) negObjInRange = 0;
		}
	}
}
