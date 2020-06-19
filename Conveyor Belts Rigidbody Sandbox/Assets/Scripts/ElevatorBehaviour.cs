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
    private int destination = 0;

    private void Start()
    {
        //destinationArray = GetComponent<Transform[]>();
        rigidbodyObj = GetComponent<Rigidbody>();
    }

    public void MoveToNextDestination()
    {
        if (destination <= destinationArray.Length-1)
        {
            MoveTowardsPoint(destinationArray[destination].position, 1);
        }

        if (destination >= destinationArray.Length)
        {
            destination = 0;
        }
    }

    public void MoveToPreviousDestination()
    {
        if (destination > 0)
        {
            MoveTowardsPoint(destinationArray[destination].position, -1);
        }

        if (destination <= 0)
        {
            destination = destinationArray.Length-1;
        }
    }

    public void MoveToStartingPoint()
    {
        destination = 0;

        MoveTowardsPoint(destinationArray[destination].position, 0);
    }

    public void MoveTowardsPoint(Vector3 target, int direction)
    {
        if (rigidbodyObj.position != target)
        {
            rigidbodyObj.MovePosition(Vector3.MoveTowards(rigidbodyObj.position, target, (speed/10)*Time.deltaTime));
        }
        else
        {
            destination += direction;
        }
    }
}
