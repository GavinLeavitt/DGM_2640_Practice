using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionsArgHandler : MonoBehaviour
{
    public UnityEvent startEvent;

    private void Start()
    {
        startEvent.Invoke();
    }

    [Serializable]
    public struct Handlers
    {
        public GameAction action;
		public UnityEvent<object> actionEvent;
        
        internal void Respond(object eventObj)
        {
            actionEvent.Invoke(eventObj);
        }
    }
    
    public List<Handlers> handlerList;
    
    private void OnEnable()
    {
        foreach (var obj in handlerList)
        {
            obj.action.raise += obj.Respond;
        }
    }
}