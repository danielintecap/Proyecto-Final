using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMesh_Enemy : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent Agent;
    public Transform pointer;
    public float LookRadius = 10f;
    public float DistanciaDisparo = 4f;
    public Animator animator;



    public float tiempo;
    public float tiempoRestante;

    public int vida;

    public GameObject ColliderAttackL;
    public GameObject ColliderAttackR;
    public GameObject ParticulaR;
    public GameObject ParticulaL;
    public Transform R;
    public Transform L;





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
            animator.SetBool("Walk", true);
            Agent.speed = 5f;

            if (distancia <= DistanciaDisparo)
            {
                animator.SetBool("Disparo", true);
                ColliderAttackL.SetActive(true);
                ColliderAttackR.SetActive(true);
                Agent.speed = 0f;
                Instantiate(ParticulaR, R.position, R.rotation);
                Instantiate(ParticulaL, L.position, L.rotation);
            }
            else
            {
                animator.SetBool("Disparo", false);
                ColliderAttackL.SetActive(false);
                ColliderAttackR.SetActive(false);
                /*ParticulaR.Play();
                ParticulaL.Play();*/
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
