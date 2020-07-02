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
    public int destination = 0;
    public int startPoint = 0;
    public int endPoint = 1;

    private void Start()
    {
        //destinationArray = GetComponent<Transform[]>();
        rigidbodyObj = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        MoveTowardsPoint(destinationArray[destination].position);
    }

    public void UpdateDestination(int newDestination)
    {
        destination = newDestination;
    }

    public void UpdateSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    
    public void UpdateStartPoint(int newStart)
    {
        startPoint = newStart;
    }

    public void UpdateEndPoint(int newEnd)
    {
        endPoint = newEnd;
    }
    
    public void FlipDirection()
    {
        var newStart = endPoint;
        var newEnd = startPoint;
        startPoint = newStart;
        endPoint = newEnd;
    }

    public void SetDestinationToStart()
    {
        destination = startPoint;
    }

    public void SetDestinationToEnd()
    {
        destination = endPoint;
    }

    public void MoveTowardsPoint(Vector3 target)
    {
        if (rigidbodyObj.position == target) return;
        rigidbodyObj.MovePosition(Vector3.MoveTowards(rigidbodyObj.position, target, (speed/10)*Time.deltaTime));
    }
}
