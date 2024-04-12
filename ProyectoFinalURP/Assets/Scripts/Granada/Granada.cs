using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public GameObject granada;
    public Transform pointerGranada;
    public float rango = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            instanciaGranada();
        }   
    }
    void instanciaGranada()
    {
        GameObject copiaGranada = Instantiate(granada, pointerGranada.position, pointerGranada.rotation);
        copiaGranada.GetComponent<Rigidbody>().AddForce(pointerGranada.forward * rango, ForceMode.Impulse);
    }
}
