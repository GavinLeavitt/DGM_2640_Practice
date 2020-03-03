using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehaviour : IDBehaviour
{
    public WorkSystemManager workSystemManagerObj;
    private NameId otherIdObj;
   
    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IDBehaviour>().nameIdObj;
        CheckId();
    }

    private void CheckId()
    {
        foreach (var obj in workSystemManagerObj.workIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.workSystemObj.Work();
                obj.workEvent.Invoke();
            }
        }
    }
}