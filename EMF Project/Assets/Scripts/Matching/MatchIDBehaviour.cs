using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIdBehaviour : IdBehaviour
{
  
    [Serializable]
    public struct possibleMatch
    {
        public NameId nameIdObj;
        public UnityEvent enterEvent;
        public UnityEvent exitEvent;
    }

    public List<possibleMatch> nameIdList;
    [SerializeField]
    public Dictionary<NameId, UnityEvent> nameIdDictionary;
   
   
    private NameId otherIdObj;
   
    private void OnTriggerEnter(Collider other)
    {
        var nameId = other.GetComponent<IdBehaviour>().nameIdObj;
        if (nameId == null) return;
      
        otherIdObj = nameId;
        EnterCheckId();
    }

    private void OnTriggerExit(Collider other)
    {
        var nameId = other.GetComponent<IdBehaviour>().nameIdObj;
        if (nameId == null) return;

        otherIdObj = nameId;
        ExitCheckId();
    }

    private void EnterCheckId()
    {
        foreach (var obj in nameIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.enterEvent.Invoke();
            }
        }
    }
    
    private void ExitCheckId()
    {
        foreach (var obj in nameIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.exitEvent.Invoke();
            }
        }
    }
}