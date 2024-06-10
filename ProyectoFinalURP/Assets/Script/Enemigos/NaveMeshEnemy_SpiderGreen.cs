using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMeshEnemy_SpiderGreen : Explosion_SpiderGreen
{
    private UnityEngine.AI.NavMeshAgent Agent;
    public Transform pointer;
    public float LookRadius = 10f;
    public float DistanciaAtaque = 4f;
    public Animator animator;



    public float tiempo;
    public float tiempoRestante;

    public int vida;

    //public Explosion_SpiderGreen explotar;





    void Start()
    {
        Agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(pointer.position, transform.position);

        if (distancia <= LookRadius)
        {
            FaceTarget();
            Agent.SetDestination(pointer.position);
            animator.SetBool("Run", true);
            Agent.speed = 5f;

            if (distancia <= DistanciaAtaque)
            {
                animator.SetBool("Attack", true);
                //explotar.ExplotarSpiderGreen();
                ExplotarSpiderGreen();

                Agent.speed = 0f;

            }
            else
            {
                animator.SetBool("Attack", false);

                /*ParticulaR.Play();
                ParticulaL.Play();*/
            }
        }

        else
        {
            animator.SetBool("Run", false);
            Agent.speed = 0f;
        }

        Debug.Log(distancia);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, DistanciaAtaque);
    }

    void FaceTarget()
    {
        Vector3 direction = (pointer.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 1f); ;
    }


    void Resetear()
    {
        tiempoRestante = tiempo;
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bala")
        {
            vida = vida - 20;

            if (vida == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
