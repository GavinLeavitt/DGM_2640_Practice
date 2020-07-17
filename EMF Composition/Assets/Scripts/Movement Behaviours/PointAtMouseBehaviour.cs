using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class PointAtMouseBehaviour : MonoBehaviour
{
    public Transform activeTransform;
    public float speed = 0.1f;
    
	private void Awake()
	{
		activeTransform = GetComponent<Transform>();
	}

    private void Update()
    {
        // Point transform towards mouse position
        if (activeTransform == null) return;
        var mouseWorld = -Vector3.one;
        var plane = new Plane(Vector3.up, activeTransform.position);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distanceToPlane;

        if (plane.Raycast(ray, out distanceToPlane))
        {
            mouseWorld = ray.GetPoint(distanceToPlane);
        }

        var forward = mouseWorld - activeTransform.position;
        var dirTo = Quaternion.LookRotation(forward, Vector3.up);
        activeTransform.rotation = Quaternion.Lerp(activeTransform.rotation, dirTo, speed * Time.deltaTime);
    }

    public void TransformSwap(Transform newTransform)
    {
        activeTransform = newTransform;
    }
}