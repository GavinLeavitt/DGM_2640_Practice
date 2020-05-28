using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MagnetObj))]
public class MagnetizeBehaviour : MonoBehaviour {

	public MagnetObj magnetObj;
	public float constForce = 80f;
	
	public void Awake()
	{
		magnetObj = GetComponent<MagnetObj>();
	}

	public void Magnetize(MagnetObj targetMagnet)
	{
		var thisPosition = magnetObj.rigidbodyObj.position;
		var targetPosition = targetMagnet.rigidbodyObj.position;
		var distanceBetweenPositions = Vector3.Distance(targetPosition, thisPosition);
		Debug.Log(distanceBetweenPositions);
		var vectorBetweenPositions = Vector3.Normalize(thisPosition - targetPosition);
		Debug.Log(vectorBetweenPositions);
		// Apply force according to Coulomb's law
		magnetObj.rigidbodyObj.AddForce(constForce * ((magnetObj.charge * targetMagnet.charge) / Mathf.Pow(Mathf.Abs(distanceBetweenPositions), 2.0f)) * vectorBetweenPositions);
	}
}