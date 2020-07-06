using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Actions/Game Action")]
public class GameAction : ScriptableObject
{
    public UnityAction<object> raise;
    public UnityAction<Coroutine> raiseCoroutine;
    public UnityAction raiseNoArgs;
    
    public void RaiseAction()
    {
        if (raiseNoArgs == null) return;
        raiseNoArgs.Invoke();
    }

    public void RaiseAction(Object obj)
    {
        if (raise == null) return;  
        raise.Invoke(obj);
    }

    public void RaiseAction(float obj)
    {
        if (raise == null) return;  
        raise.Invoke(obj);
    }
    
    public void RaiseAction(int obj)
    {
        if (raise == null) return;  
        raise.Invoke(obj);
    }

    public void RaiseAction(Transform obj)
    {
        if (raise == null) return;  
        raise.Invoke(obj);
    }

    public void RaiseAction(Coroutine obj)
    {
        if (raiseCoroutine == null) return;
        raiseCoroutine.Invoke(obj);
    }
}