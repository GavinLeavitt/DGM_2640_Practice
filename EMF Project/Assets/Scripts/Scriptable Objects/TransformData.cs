using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TransformData : ScriptableObject
{
    public Transform transformObject;

    public void SwapTransform(Transform newTransformObj)
    {
        transformObject = newTransformObj;
    }
}