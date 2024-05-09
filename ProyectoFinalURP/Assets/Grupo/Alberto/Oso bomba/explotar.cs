using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explotar : MonoBehaviour
{
    public GameObject particulaExplosion;
    public float delay = 3f;
    public float radius = 20f;
    public float FuerzaExplosion = 30F;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ExplotarGranada", delay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ExplotarGranada()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);


        foreach (Collider cercano in colliders)
        {
            Rigidbody rb = cercano.GetComponent<Rigidbody>();
           
          if (rb != null)

          {
                rb.AddExplosionForce(FuerzaExplosion, transform.position, radius, 1f, ForceMode.Impulse);
          }

            Instantiate(particulaExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
