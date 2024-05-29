using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject particulaExplosion; //partiicula de explosion
    public float delay = 3f;
    public float rango = 20f;
    public float fuerzaExplosion = 30f;

    void Start()
    {
        Invoke("ExplosionGranada", delay);
    }

    void ExplosionGranada()
    {
        //Busca objetos que tengan collider y los agrupa
        Collider[] Colliders = Physics.OverlapSphere(transform.position, rango);

        //Buscar si tienen rigidbody
        foreach(Collider cercano in Colliders)
        {
            Rigidbody rb = cercano.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(fuerzaExplosion, transform.position, rango, 1f, ForceMode.Impulse);
            }
            Instantiate(particulaExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
