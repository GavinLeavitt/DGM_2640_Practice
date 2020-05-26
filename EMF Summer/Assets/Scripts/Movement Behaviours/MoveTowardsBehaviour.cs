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
		var posToMoveTowards = transform.position;
		rigidbodyObj.MovePosition(posToMoveTowards);
	}

	public void MoveAwayFromTransform(Transform transform)
	{
		if (!ableToMove) return;
		
	}
}