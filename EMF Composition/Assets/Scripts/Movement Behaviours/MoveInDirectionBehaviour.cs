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
			rigidbodyObj.useGravity = false;
			rigidbodyObj.MovePosition(rigidbodyObj.position + Time.deltaTime*speed*direction.value);
		} else 
		{
			rigidbodyObj.useGravity = true;
		}
	}

	public void MoveAwayFromDirection(Vector3Data direction)
	{
		if (!useRangeCheck || rangeCheck.value > 0)
		{
			rigidbodyObj.useGravity = false;
			rigidbodyObj.MovePosition(rigidbodyObj.position - Time.deltaTime*speed*direction.value);
		} else 
		{
			rigidbodyObj.useGravity = true;
		}
	}

	public void ToggleMove(bool isEnabled)
	{
		canMove = isEnabled;
	}

	public void UpdateRangeObj(IntData newRange)
	{
		if (!useRangeCheck) return;
		rangeCheck = newRange;
	}
}