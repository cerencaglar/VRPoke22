using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonPushTrigger : MonoBehaviour
{
    [Header("XR Poke Events")]
    public UnityEvent OnPokeEnter;
    public UnityEvent OnPokeExit;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("press"))
        {
            OnPokeEnter?.Invoke();
            Debug.Log("Tetikleme baþladý.");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("press"))
        {
            OnPokeExit?.Invoke();
            Debug.Log("Tetikleme bitti.");
        }
    }
}
