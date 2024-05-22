using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion : MonoBehaviour
{
    public float CantidadCura;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<Stats_Player>())


        {
            other.GetComponent<Stats_Player>().RecibirCura(CantidadCura);
            Destroy(gameObject);
        }
    }
}

