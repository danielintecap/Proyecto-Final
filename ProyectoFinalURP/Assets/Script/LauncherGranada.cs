using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherGranada : MonoBehaviour
{
    public GameObject Granada;
    public Transform PointGranada;
    public float rango = 20f;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            InstanciarGranada();
        }
    }

    void InstanciarGranada()
    {
        GameObject copiarGranada = Instantiate(Granada, PointGranada.position, PointGranada.rotation);
        copiarGranada.GetComponent<Rigidbody>().AddForce(PointGranada.forward * rango, ForceMode.Impulse);
    }

}

