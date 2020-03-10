using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponCollectible : Collectible
{
    public UnityEvent UseEvent;
    public override void Use()
    {
        UseEvent.Invoke();
    }
}
