using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aliados : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent Agent;
    public Transform pointer;
    public float LookRadius = 20f;
    public float Distancia_Disparo = 10f;
    public Animator animator;

    public float tiempo;
    public float tiempoRestante;

    public int vida;

    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaEnemigo = Vector3.Distance(pointer.position, transform.position);

        //dispara al enemigo
        if (distanciaEnemigo <= LookRadius)
        {
            FaceTarget();
            Agent.SetDestination(pointer.position);
            animator.SetBool("Walk", true);
            Agent.speed = 5f;
            if (distanciaEnemigo <= Distancia_Disparo)
            {
                animator.SetBool("Walk", false);
                Agent.speed = 0f;
            }
            else
            {
                animator.SetBool("Disparo", false);
            }
        }
        else
        {
            animator.SetBool("Walk", false);
            Agent.speed = 0f;
        }
        Debug.Log(distanciaEnemigo);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, LookRadius);

        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position, Distancia_Disparo);
    }
    void FaceTarget()
    {
        //enemigos
        Vector3 directionEnemigo = (pointer.position - transform.position).normalized;
        Quaternion lookRotationEnemigo = Quaternion.LookRotation(new Vector3(directionEnemigo.x, 0, directionEnemigo.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotationEnemigo, 1f);
    }
}

