using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject {
	public Vector3 vectorObj;

	public void UpdateVector(Vector3 newVector)
	{
		vectorObj = newVector;
	}

	public void UpdateVectorToTransformForward(Transform transform)
	{
		vectorObj = transform.rotation * Vector3.forward;
	}
}
