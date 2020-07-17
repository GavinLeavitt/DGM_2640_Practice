using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject {
	public Vector3 value;

	public void UpdateVector(Transform transformObj)
	{
		value = transformObj.position;
	}

	public void UpdateVectorToTransformForward(Transform transform)
	{
		value = transform.rotation * Vector3.forward;
	}
}
