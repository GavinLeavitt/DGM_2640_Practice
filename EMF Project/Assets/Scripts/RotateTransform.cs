using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTransform : MonoBehaviour {

	public TransformData transformData;
	public float rotateSpeed = 2;
	
	private void Update()
	{
		var rotateAxis = Input.GetAxis("Rotation");
		transformData.transformObject.Rotate(0.0f, rotateAxis*rotateSpeed, 0.0f);
	}
}