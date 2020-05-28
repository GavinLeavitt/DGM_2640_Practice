using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour {
	public UnityEvent mbEvent = new UnityEvent();
	public int mouseButton = 0;

	private void Update()
	{
		if (mbEvent == null) return;

		if (Input.GetMouseButton(mouseButton))
		{
			mbEvent.Invoke();
		}
	}
}
