using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject {
	public Vector3 vector3Value;

	public void UpdateVectorToTransform(Transform newTransform)
	{
		var direction = newTransform.TransformDirection(Vector3.forward);
		vector3Value = direction;
	}
}