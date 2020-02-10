using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class RotateTransform : MonoBehaviour {

	public Transform transformToRotate;
	void Start () {
		transformToRotate = GetComponent<Transform>();
	}
	void Update () {
		if (Input.GetKey("q")) {
			transformToRotate.Rotate(0.0f, -2.0f, 0.0f);
		}

		if (Input.GetKey("e")) {
			transformToRotate.Rotate(0.0f, 2.0f, 0.0f);
		}
	}
}