using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour {
	public UnityEvent lmbEvent, rmbEvent;

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			lmbEvent.Invoke();
		}

		if (Input.GetMouseButton(1))
		{
			rmbEvent.Invoke();
		}
	}
}
