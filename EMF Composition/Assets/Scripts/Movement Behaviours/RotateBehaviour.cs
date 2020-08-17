using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour {

	public Transform transformObj;
	public float direction = 1.0f;
	public float speed = 10.0f;
	public string axis = "y";

	public void FixedUpdate()
	{
		switch(axis)
		{
			case "x":
				direction = Mathf.Sign(direction);
				transformObj.RotateAround(transformObj.position, Vector3.right, direction * speed * Time.deltaTime);
				break;
			
			case "y":
				direction = Mathf.Sign(direction);
				transformObj.RotateAround(transformObj.position, Vector3.up, direction * speed * Time.deltaTime);
				break;

			case "z":
				direction = Mathf.Sign(direction);
				transformObj.RotateAround(transformObj.position, Vector3.forward, direction * speed * Time.deltaTime);
				break;
		}
	}

	public void UpdateSpeed(float newSpeed)
	{
		speed = newSpeed;
	}

	public void UpdateDirection(float newDirection)
	{
		direction = newDirection;
	}

	public void UpdateAxis(string newAxis)
	{
		axis = newAxis;
	}
}
