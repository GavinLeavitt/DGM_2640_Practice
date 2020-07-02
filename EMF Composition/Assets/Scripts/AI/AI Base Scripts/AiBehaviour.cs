using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;


[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Collider))]
public class AiBehaviour : MonoBehaviour
{
    public AiBrain aiBrainObj;
    private NavMeshAgent agent;
    public bool CanRun = true;
    public UnityEvent startEvent, triggerEnterEvent, triggerExitEvent;
    
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    public void Stop(bool stopped)
    {
        agent.isStopped = stopped;
    }

    private void FixedUpdate()
    {
        aiBrainObj.Navigate(agent);
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}