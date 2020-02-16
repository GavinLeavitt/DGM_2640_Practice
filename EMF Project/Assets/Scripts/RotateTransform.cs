using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTransform : MonoBehaviour {

	public Transform transformObj;
	public float rotateSpeed = 2;
	
	private void Update()
	{
		var rotateAxis = Input.GetAxis("Rotation");
		transformObj.Rotate(0.0f, rotateAxis*rotateSpeed, 0.0f);
	}
}