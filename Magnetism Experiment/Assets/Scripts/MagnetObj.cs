using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MagnetObj {
	public float charge;
	public Rigidbody rigidbodyObj;

	public MagnetObj()
	{

	}

	public void ChangePolarity(float newPolarity)
	{
		charge = newPolarity;
	}
}