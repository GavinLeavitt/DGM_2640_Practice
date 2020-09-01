using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyConstraintBehaviour : MonoBehaviour {

	public Rigidbody bodyObj;

	private void Start()
	{
		bodyObj = GetComponent<Rigidbody>();
	}

	public void FreezePosX()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezePositionX;
	}

	public void FreezePosY()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezePositionY;
	}

	public void FreezePosZ()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezePositionZ;
	}

	public void FreezeRotX()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeRotationX;
	}

	public void FreezeRotY()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeRotationY;
	}

	public void FreezeRotZ()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeRotationZ;
	}

	public void FreezeAllPosButX()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
	}

	public void FreezeAllPosButY()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
	}

	public void FreezeAllPosButZ()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
	}

	public void FreezeAllRotButX()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
	}

	public void FreezeAllRotButY()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
	}

	public void FreezeAllRotButZ()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
	}

	public void FreezeAllPos()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezePosition;
	}

	public void FreezeAllRot()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeRotation;
	}

	public void FreezeAllConstraints()
	{
		bodyObj.constraints = RigidbodyConstraints.FreezeAll;
	}

	public void RemoveConstraints()
	{
		bodyObj.constraints = RigidbodyConstraints.None;
	}
}
