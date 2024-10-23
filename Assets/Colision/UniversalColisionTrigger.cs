using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UniversalColisionTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent _onEnterEvent;
    [SerializeField] UnityEvent _onExitEvent;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        //Debug.Log("colliding with " + other.gameObject.name);
        _onEnterEvent?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        //Debug.Log("colliding with " + other.gameObject.name);
        _onExitEvent?.Invoke();
    }
}
