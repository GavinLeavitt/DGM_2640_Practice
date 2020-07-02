using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour {
	public UnityEvent lmbEvent, lmbDownEvent, lmbUpEvent, rmbEvent, rmbDownEvent, rmbUpEvent;

	private void FixedUpdate()
	{
		if (Input.GetMouseButton(0))
		{
			lmbEvent.Invoke();
		}

		if (Input.GetMouseButtonDown(0))
		{
			lmbDownEvent.Invoke();
		}

		if (Input.GetMouseButtonUp(0))
		{
			lmbUpEvent.Invoke();
		}

		if (Input.GetMouseButton(1))
		{
			rmbEvent.Invoke();
		}

		if (Input.GetMouseButtonDown(1))
		{
			rmbDownEvent.Invoke();
		}

		if (Input.GetMouseButtonUp(1))
		{
			rmbUpEvent.Invoke();
		}
	}
}
