using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav_Enemie : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent Agent;
    public Transform pointer;
    public float LookRadius = 20f;
    public float Distancia_Disparo = 10f;
    public Animator animator;
    public GameObject bala;
    public Transform pointerBala;

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
        float distancia = Vector3.Distance(pointer.position, transform.position);

        if(distancia<=LookRadius)
        {
            FaceTarget();
            Agent.SetDestination(pointer.position);
            animator.SetBool("Walk", true);
            Agent.speed = 5f;
            if(distancia<= Distancia_Disparo)
            {
                animator.SetBool("Disparo", true);
                Agent.speed = 0f;
                DisparoBala();
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

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, Distancia_Disparo);
    }
    void FaceTarget()
    {
        Vector3 direction = (pointer.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 1f);
    }

    void DisparoBala()
    {
        tiempoRestante = tiempoRestante - Time.deltaTime;
        if(tiempoRestante <= 0)
        {
            Instantiate(bala, pointerBala.position, transform.rotation);
            Resetear();
        }
    }
    void Resetear()
    {
        tiempoRestante = tiempo;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            vida = vida - 20;

            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
