using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsBehaviour : MonoBehaviour {
	public UnityEvent updateEvent, fixedUpdateEvent, startEvent;

	private void Start()
	{
		startEvent.Invoke();
	}

	private void FixedUpdate()
	{
		fixedUpdateEvent.Invoke();
	}

	private void Update()
	{
		updateEvent.Invoke();
	}

}
