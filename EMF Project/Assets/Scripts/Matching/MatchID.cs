using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchId : MonoBehaviour
{
    public NameId id;
    public UnityEvent onMatch;
    public UnityEvent noMatch;
    public bool MatchMade { private get; set; }

    private void OnTriggerEnter(Collider other)
    {
        var otherId = other.GetComponent<MatchId>();
        if (otherId == null) return;
        
        if (otherId.id == id || otherId.MatchMade)
        {
            onMatch.Invoke();
        }
        else
        {
            noMatch.Invoke();
        }
    }
}