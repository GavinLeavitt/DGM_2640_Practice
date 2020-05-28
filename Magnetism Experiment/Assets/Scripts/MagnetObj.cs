using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MagnetObj : MonoBehaviour {
	public float charge = 1.0f;
	public Rigidbody rigidbodyObj;

	public void ChangePolarity(float newPolarity)
	{
		charge = newPolarity;
	}
}