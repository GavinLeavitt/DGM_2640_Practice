using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction action;
    public UnityAction<Transform> transformAction;
    public UnityAction<bool> booleanAction;
    public UnityAction<float> floatAction;
    
    public void Raise()
      {
      if (action != null)
        {
          action.Invoke();
        }
        
    }

      public void Raise(Transform transformObj)
      {
          if (transformAction != null)
        {
          transformAction.Invoke(transformObj);
        }
      }

      public void Raise(bool boolValue)
      {
        if (booleanAction == null) return;
        booleanAction.Invoke(boolValue);
      }

      public void Raise(float floatValue)
      {
        if (floatAction == null) return;
        floatAction.Invoke(floatValue);
      }
}
