using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    private NavMeshAgent Agent;
    public Transform pointer;
    public float LookRadius = 80f;
    public float DistanciaDisparo = 30f;
    public Animator animator;
    public GameObject Bala;
    public float tiempo;
    public float tiempoRestante;
    public Transform PointerBala;
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(pointer.position, transform.position);

        if(distancia <= LookRadius)
        {
            FaceTarget(); 
            Agent.SetDestination(pointer.position);
            animator.SetBool("Walk", true);
            Agent.speed = 5f;

            if (distancia <= DistanciaDisparo)
            {
                animator.SetBool("Disparo", true);
                Agent.speed = 0f;
                DispararBala();
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

    Debug.Log(distancia);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, DistanciaDisparo);
    }
    void FaceTarget()
    {
        Vector3 direction = (pointer.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 1f);
    }
    void DispararBala()

    {
        tiempoRestante = tiempoRestante - Time.deltaTime;

        if (tiempoRestante <= 0f)
        {
            Instantiate(Bala, PointerBala.position, transform.rotation);
            Resetear();
        }
    }
    void Resetear()
    {
        tiempoRestante = tiempo;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            vida = vida - 20;

            if (vida == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
