using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CraneBehaviour : MonoBehaviour {

	public UnityEvent rotateEvent, extendEvent, lowerEvent, grabEvent, riseEvent, retractEvent, dropEvent;
	public int craneState;

	public void FixedUpdate()
	{
		switch (craneState)
		{
			case 0:
				rotateEvent.Invoke();
				break;

			case 1:
				extendEvent.Invoke();
				break;

			case 2:
				lowerEvent.Invoke();
				break;

			case 3:
				grabEvent.Invoke();
				break;

			case 4:
				riseEvent.Invoke();
				break;

			// 0 rotateEvent should be called again, then 5 retractEvent
			
			case 5:
				retractEvent.Invoke();
				break;

			//6 dropEvent should be called on collision with the drop point

			case 6:
				dropEvent.Invoke();
				break;
		}
	}

	public void UpdateCraneState(int newState)
	{
		craneState = newState;
	}
}
