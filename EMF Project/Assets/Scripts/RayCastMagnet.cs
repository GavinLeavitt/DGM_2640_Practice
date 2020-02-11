using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastMagnet : MonoBehaviour
{
	public PlayerController player;
	public PositionData aimRotation;
	public string activateKey = "f";
	public float electricCharge = 1.0f;

	private void Update()
	{
		if (Input.GetKey(activateKey))
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*10.0f, Color.red, 0.5f);
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 7.0f))
			{
				if (hit.collider.CompareTag("HeavyMagnet"))
				{
					aimRotation.positionVector = transform.TransformDirection(new Vector3(0, 0, electricCharge));
					player.magnetize = true;
					//Debug.Log("Hit" + hit.point);
				} else if (hit.collider.CompareTag("LightMagnet"))
				{
					// Push light magnetic object away from magnet	
				}
			}
			else
			{
				player.magnetize = false;
			}
			
		}
		else
		{
			player.magnetize = false;
		}
	}
}
