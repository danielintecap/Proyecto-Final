using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suscribirse_Eventos : MonoBehaviour
{
    //Escalas
    public GameObject player;
    public GameObject trampa;
    public GameObject paredMata;
    public Vector3 escala;
    public Vector3 escalaNormal;
    public Vector3 escalaTrampa;
    public Vector3 escalaTrampaNormal;
    public float speed;

    public void EscalaPlayer()
    {
        player.transform.localScale = escala;
    }

    public void EscalaNormalPlayer()
    {
        player.transform.localScale = escalaNormal;
    }

    public void EscalaTrampa()
    {
        trampa.transform.localScale = escalaTrampa;
    }

    public void EscalaTrampaNormal()
    {
        trampa.transform.localScale = escalaTrampaNormal;
    }
}
