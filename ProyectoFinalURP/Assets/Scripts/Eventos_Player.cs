using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos_Player : MonoBehaviour
{
    [SerializeField] private UnityEvent OnTrigger;
    [SerializeField] private UnityEvent ExitTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            OnTrigger.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            ExitTrigger.Invoke();
        }
    }
}
