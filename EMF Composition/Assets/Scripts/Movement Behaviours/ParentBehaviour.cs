using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBehaviour : MonoBehaviour {
	public GameObject gameObj;

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Pickup") return;
		other.transform.parent = gameObj.transform;
		other.transform.localPosition = new Vector3(0, 0, 0);
	}

	public void OnTriggerExit(Collider other)
	{
		if (other.tag != "Pickup") return;
		other.transform.parent = null;
	}

	public void SetParent(GameObject newParent)
	{
		gameObj.transform.parent = newParent.transform;
		Debug.Log("New Parent: " + gameObj.transform.parent.name);

		if (newParent.transform.parent != null)
		{
			Debug.Log("New grandparent: " + gameObj.transform.parent.parent.name);
		}
	}

	public void DetachFromParent()
	{
		gameObj.transform.parent = null;
	}

	public void DropAllChildren(Vector3Data dropoffPoint)
	{
		foreach (Transform child in transform)
		{
			child.position = dropoffPoint.value;
			child.parent = null;
		}
	}
}
