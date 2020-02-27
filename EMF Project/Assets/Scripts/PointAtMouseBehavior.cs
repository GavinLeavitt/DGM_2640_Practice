using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtMouseBehavior : MonoBehaviour
{
    public Transform activeTransform;
    
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
        activeTransform.rotation = Quaternion.LookRotation(forward, Vector3.up);
    }

    public void TransformSwap(Transform newTransform)
    {
        activeTransform = newTransform;
    }
}