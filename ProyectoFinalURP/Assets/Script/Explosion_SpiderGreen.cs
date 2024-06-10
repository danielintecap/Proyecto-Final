using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_SpiderGreen : MonoBehaviour
{
    public float delay = 3f;
    public float radius = 20f;
    public float FuerzaExplosion = 30f;


    void Start()
    {
        Invoke("ExplotarSpiderGreen", delay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExplotarSpiderGreen()
    {
        //Buscar objetos que tengan collider y que est�n adentro del radio y agruparlos en el grupo llamado "colliders"
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        //Buscar adentro del grupo "colliders" objetos que tengan rigibody y agregarles fuerza

        foreach (Collider cercano in colliders)
        {
            Rigidbody rb = cercano.GetComponent<Rigidbody>();

            if (rb != null)

            {
                rb.AddExplosionForce(FuerzaExplosion, transform.position, radius, 1f, ForceMode.Impulse);
            }

        }
    }
}