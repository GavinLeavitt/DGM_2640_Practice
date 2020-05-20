using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent lmbInput, rmbInput, lmbDownInput, rmbDownInput;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            lmbInput.Invoke();
        }

        if (Input.GetMouseButton(1))
        {
            rmbInput.Invoke();
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            lmbDownInput.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
            rmbDownInput.Invoke();
        }
    }
}
