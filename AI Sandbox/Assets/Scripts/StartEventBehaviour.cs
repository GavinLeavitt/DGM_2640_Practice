using UnityEngine;
using UnityEngine.Events;

public class StartEventBehaviour : MonoBehaviour {
	public UnityEvent awakeEvent, startEvent;

	private void Awake()
	{
		awakeEvent.Invoke();
	}

	private void Start()
	{
		startEvent.Invoke();
	}
}