using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class RotateTransform : MonoBehaviour {

	public Transform transformToRotate;
	public string cwKey = "x";
	public string ccwKey = "z";
	
	void Start () {
		transformToRotate = GetComponent<Transform>();
	}
	
	void Update () {
		if (Input.GetKey(ccwKey)) {
			transformToRotate.Rotate(0.0f, -2.0f, 0.0f);
		}

		if (Input.GetKey(cwKey)) {
			transformToRotate.Rotate(0.0f, 2.0f, 0.0f);
		}
	}
}