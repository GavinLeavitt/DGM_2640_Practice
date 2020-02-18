using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform[]))]
[RequireComponent(typeof(Rigidbody))]
public class ElevatorBehaviour : MonoBehaviour
{
    public Transform[] destinationArray;
    public float speed = 1f;
    public Rigidbody rigidbodyObj;
    private int destination;

    private void Start()
    {
        destinationArray = GetComponent<Transform[]>();
        rigidbodyObj = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (destination <= destinationArray.Length-1)
        {
            MoveTowardsPoint(destinationArray[destination].position);
        }

        if (destination >= destinationArray.Length)
        {
            destination = 0;
        }
    }

    private void MoveTowardsPoint(Vector3 target)
    {
        if (rigidbodyObj.position != target)
        {
            rigidbodyObj.MovePosition(Vector3.MoveTowards(rigidbodyObj.position, target, (speed/10)*Time.deltaTime));
        }
        else
        {
            destination++;
        }
    }
}
