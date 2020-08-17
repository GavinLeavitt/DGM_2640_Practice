using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardEventBehaviour : MonoBehaviour {
public UnityEvent leftEvent, rightEvent, upEvent, downEvent, forwardEvent, backEvent;

	private void FixedUpdate()
	{
		if (Input.GetKey("left"))
		{
			leftEvent.Invoke();
		}
	
		if (Input.GetKey("right"))
		{
			rightEvent.Invoke();
		}
	
		if (Input.GetKey("up"))
		{
			upEvent.Invoke();
		}
	
		if (Input.GetKey("down"))
		{
			downEvent.Invoke();
		}
	
		if (Input.GetKey("right shift"))
		{
			forwardEvent.Invoke();
		}
	
		if (Input.GetKey("right ctrl"))
		{
			backEvent.Invoke();
		}
	}
}
