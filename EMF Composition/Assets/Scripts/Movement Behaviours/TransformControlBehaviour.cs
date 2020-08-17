using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformControlBehaviour : MonoBehaviour {

	public Transform transformObj;
	public float direction = 1.0f;
	public float speed = 10.0f;

	public void TranslateMove(string axis)
	{
		switch(axis)
		{
			case "x":
				direction = Mathf.Sign(direction);
				transformObj.Translate(Vector3.right * direction * speed * Time.deltaTime);
				break;

			case "y":
				direction = Mathf.Sign(direction);
				transformObj.Translate(Vector3.up * direction * speed * Time.deltaTime);
				break;

			case "z":
				direction = Mathf.Sign(direction);
				transformObj.Translate(Vector3.forward * direction * speed * Time.deltaTime);
				break;
		}
	}

	public void RotateMove(string axis)
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

	public void RepositionY(float yPos)
	{
		transformObj.position = new Vector3(transformObj.position.x, yPos, transformObj.position.z);
	}
}
