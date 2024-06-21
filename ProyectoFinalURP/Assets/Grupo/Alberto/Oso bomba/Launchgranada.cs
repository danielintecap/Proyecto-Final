using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchgranada : MonoBehaviour
{
    public GameObject Granada;
    public Transform PointGranada;
    public float rango = 20f;
    public Vector3 ejes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            InstanciarGranada();
        }

    }

    void InstanciarGranada()
    {
        GameObject copiaGranada = Instantiate(Granada, PointGranada.position, PointGranada.rotation);
        copiaGranada.GetComponent<Rigidbody>().AddForce(PointGranada.forward * rango, ForceMode.Impulse);
    }
}
