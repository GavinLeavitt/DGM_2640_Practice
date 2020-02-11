using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class RayCast : MonoBehaviour
{
	public CharacterController characterController;
	public PositionData aimRotation;
	private void Start()
	{
		characterController = GetComponent<CharacterController>();
	}
	
	private void Update()
	{
		if (Input.GetKeyDown("space"))
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*10.0f, Color.red, 1.0f);
			RaycastHit hit;
			if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 30.0f)) 
				return;
			if (hit.collider.CompareTag("HeavyMagnet"))
			{
				aimRotation.positionVector = transform.TransformDirection(Vector3.forward);
				//Debug.Log("Hit" + hit.point);
			} else if (hit.collider.CompareTag("LightMagnet"))
			{
				aimRotation.positionVector = transform.TransformDirection(Vector3.forward);
			}
		}
	}
	
}
