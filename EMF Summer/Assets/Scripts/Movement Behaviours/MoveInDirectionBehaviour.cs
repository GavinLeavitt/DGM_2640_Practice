using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveInDirectionBehaviour : MonoBehaviour {
	public Rigidbody rigidbodyObj;
	public float speed = 1.0f;
	public bool canMove = false;
	public bool useRangeCheck = false;
	public IntData rangeCheck;

	public void Awake()
	{
		rigidbodyObj = GetComponent<Rigidbody>();
	}

	public void MoveInDirection(Vector3Data direction)
	{
		if (!useRangeCheck || rangeCheck.value > 0)
		{
			if (!canMove) return;
			rigidbodyObj.MovePosition(rigidbodyObj.position + Time.deltaTime*speed*direction.vector3Value);
		}
	}

	public void MoveAwayFromDirection(Vector3Data direction)
	{
		if (!useRangeCheck || rangeCheck.value > 0)
		{
			if (!canMove) return;
			rigidbodyObj.MovePosition(rigidbodyObj.position - Time.deltaTime*speed*direction.vector3Value);
		}
	}

	public void ToggleMove(bool isEnabled)
	{
		canMove = isEnabled;
	}
}