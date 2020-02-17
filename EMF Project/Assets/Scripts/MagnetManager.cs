using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetManager : MonoBehaviour
{
    public Transform pullMagnet;
    public Transform pushMagnet;
    public PositionData activeRotation;
    public BoolData playerMagnetize;
    public Transform activeTransform;

    private void Start()
    {
        activeTransform = pullMagnet;
    }

    private void Update() 
    {
        // Magnet aiming toggle
        if (Input.GetKeyDown("space"))
        {
            if (activeTransform == pullMagnet)
            {
                activeTransform = pushMagnet;
            } else 
            if (activeTransform == pushMagnet)
            {
                activeTransform = pullMagnet;
            }
        }

        // Point magnet towards mouse position
        if (activeTransform != null) 
        {
            Vector3 mouseWorld = -Vector3.one;
            Plane plane = new Plane (Vector3.up, activeTransform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distanceToPlane;

            if (plane.Raycast (ray, out distanceToPlane))
            {
                mouseWorld = ray.GetPoint(distanceToPlane);
            }

            Vector3 forward = mouseWorld - activeTransform.position;
            activeTransform.rotation = Quaternion.LookRotation(forward, Vector3.up);
        }

        // Raycast from direction of magnet on mouse input
        if (Input.GetMouseButton(1))
        {
            MagnetRayCast(pullMagnet, 1f, 8f, Color.red);
        } 
        else if (Input.GetMouseButton(0))
        {
            MagnetRayCast(pushMagnet, -1f, 8f, Color.blue);
        } 
        else 
        {
            playerMagnetize.thisBool = false;
        }

    }

    private void MagnetRayCast(Transform originMagnet, float polarity, float distance, Color debugRayColor)
    {
        Debug.DrawRay(originMagnet.position, originMagnet.TransformDirection(Vector3.forward) * distance, debugRayColor);
        RaycastHit hit;
            if (Physics.Raycast(originMagnet.position, originMagnet.TransformDirection(Vector3.forward), out hit, distance))
            {
                if (hit.collider.CompareTag("HeavyMagnet"))
                {
                    Debug.Log("Hit" + hit.collider);
                    activeRotation.positionVector = originMagnet.TransformDirection(0f, 0f, polarity);
                    Debug.Log(activeRotation.positionVector);
                    playerMagnetize.thisBool = true;
                } else 
                {
                    playerMagnetize.thisBool = false;
                }
            } else
            {
                playerMagnetize.thisBool = false;
            }
    }
}
