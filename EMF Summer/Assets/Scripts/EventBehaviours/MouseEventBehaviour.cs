using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour {
	public UnityEvent lmbEvent, lmbUpEvent, rmbEvent, rmbUpEvent;

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			lmbEvent.Invoke();
		}

		if (Input.GetMouseButtonUp(0))
		{
			lmbUpEvent.Invoke();
		}

		if (Input.GetMouseButton(1))
		{
			rmbEvent.Invoke();
		}

		if (Input.GetMouseButtonUp(1))
		{
			rmbUpEvent.Invoke();
		}
	}
}
