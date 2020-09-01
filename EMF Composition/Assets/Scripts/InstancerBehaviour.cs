using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InstancerBehaviour : MonoBehaviour {
	public UnityEvent startEvent;

	private void Start() {
		startEvent.Invoke();
	}
	
	public void InstanceToPosition(GameObject prefab)
	{
		Instantiate(prefab, transform.position, Quaternion.identity);
	}
}
