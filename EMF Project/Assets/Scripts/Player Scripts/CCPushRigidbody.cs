using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCPushRigidbody : MonoBehaviour {
	public float pushSpeed = 2.0f;
	// Push moveable blocks while Character Controller is moving
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
		var body = hit.collider.attachedRigidbody;

		if (body == null || body.isKinematic)
		{
			return;
		}

		if (hit.moveDirection.y < -0.3)
		{
			return;
		}

		if (body.tag != "Moveable")
		{
			return;
		}

		var pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
		body.velocity = pushDir * pushSpeed;
	}
}
