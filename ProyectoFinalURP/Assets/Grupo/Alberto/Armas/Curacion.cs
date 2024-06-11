using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion : MonoBehaviour
{
    public float CantidadCura;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<UI_Stats>())


        {
            other.GetComponent<UI_Stats>().RecibirCura(CantidadCura);
            Destroy(gameObject);
        }
    }
}

