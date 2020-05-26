using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveTowardsBehaviour : MonoBehaviour {

	public Rigidbody rigidbodyObj;
	public float force = 1.0f;
	
	public void Awake()
	{
		rigidbodyObj = GetComponent<Rigidbody>();
	}

	public void MoveTowards(Transform target)
	{
		rigidbodyObj.AddForce((target.position - rigidbodyObj.transform.position) * force * Time.deltaTime);
	}

	public void MoveAway(Transform target)
	{
		rigidbodyObj.AddForce(-(target.position - rigidbodyObj.transform.position) * force * Time.deltaTime);
	}
}