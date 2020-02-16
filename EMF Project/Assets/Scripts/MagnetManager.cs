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

    private void Awake()
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
        if (Input.GetMouseButton(0))
        {
            Debug.DrawRay(pushMagnet.position, pushMagnet.TransformDirection(Vector3.forward) * 15, Color.blue);
            RaycastHit pushHit;
            if (Physics.Raycast(pushMagnet.position, pushMagnet.TransformDirection(Vector3.forward), out pushHit, 15f))
            {
                if (pushHit.collider.CompareTag("HeavyMagnet"))
                {
                    activeRotation.positionVector.y = pushMagnet.rotation.y;
                    playerMagnetize.thisBool = true;
                } else 
                {
                    playerMagnetize.thisBool = false;
                }
            }
        } else 
        {
            playerMagnetize.thisBool = false;
        }

        if (Input.GetMouseButton(1))
        {
            Debug.DrawRay(pullMagnet.position, pullMagnet.TransformDirection(Vector3.forward) * 15, Color.red);
            RaycastHit pullHit;
            if (Physics.Raycast(pullMagnet.position, pullMagnet.TransformDirection(Vector3.forward), out pullHit, 15f))
            {
                if (pullHit.collider.CompareTag("HeavyMagnet"))
                {
                    activeRotation.positionVector.y = pullMagnet.rotation.y;
                    playerMagnetize.thisBool = true;
                } else 
                {
                    playerMagnetize.thisBool = false;
                }
            }
        } else 
        {
            playerMagnetize.thisBool = false;
        }
    }
}
