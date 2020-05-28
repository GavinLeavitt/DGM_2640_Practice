using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveTowardsBehaviour : MonoBehaviour {
	public Rigidbody rigidbodyObj;
	public float speed = 1.0f;
	public bool ableToMove = true;

	public void Awake()
	{
		rigidbodyObj = GetComponent<Rigidbody>();
	}

	public void MoveTowardsTransform(Transform transform)
	{
		if (!ableToMove) return;
		var thisPos = rigidbodyObj.transform.position;
		var targetPos = transform.position;
		var force = Vector3.Normalize(targetPos - thisPos) * speed;
		rigidbodyObj.AddForce(force);
	}

	public void MoveAwayFromTransform(Transform transform)
	{
		if (!ableToMove) return;
		var thisPos = rigidbodyObj.transform.position;
		var targetPos = transform.position;
		var force = Vector3.Normalize(thisPos - targetPos) * speed;
		rigidbodyObj.AddForce(force);
	}

	public void ToggleMove(bool isEnabled)
	{
		ableToMove = isEnabled;
	}
}