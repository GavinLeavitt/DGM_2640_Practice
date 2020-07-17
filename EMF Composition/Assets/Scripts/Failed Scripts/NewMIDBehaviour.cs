using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class NewMIDBehaviour : MonoBehaviour {
	public Rigidbody rigidbodyObj;
	public float speed = 1.0f;

	[Serializable]
	public struct MovementVectors
	{
		public Vector3Data targetVector;
		public bool requireRange;
		public int objInRange { get; set; }
	}

	public List<MovementVectors> vectorList;

	public void Awake()
	{
		rigidbodyObj = GetComponent<Rigidbody>();
	}

	public void MoveTowardsVector(int vectorInList)
	{
		var vec = vectorList[vectorInList];
		if (!vec.requireRange || vec.objInRange > 0)
		{
			rigidbodyObj.useGravity = false;
			rigidbodyObj.MovePosition(rigidbodyObj.position + (Time.deltaTime*speed*vec.targetVector.value));
		}
	}

	public void MoveAwayVector(int vectorInList)
	{
		var vec = vectorList[vectorInList];
		if (!vec.requireRange || vec.objInRange > 0)
		{
			rigidbodyObj.useGravity = false;
			rigidbodyObj.MovePosition(rigidbodyObj.position - (Time.deltaTime*speed*vec.targetVector.value));
		}
	}

	public void IncrementRange(int vectorInList)
	{
		var vec = vectorList[vectorInList];
		vec.objInRange = vec.objInRange + 1;
	}

	public void DecrementRange(int vectorInList)
	{
		var vec = vectorList[vectorInList];
		vec.objInRange = vec.objInRange -1;
	}
}
