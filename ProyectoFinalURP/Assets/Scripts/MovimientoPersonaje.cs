using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    float horizontal;
    float vertical;
    float RotarHorizontal;

    public float velocidad;
    public float velocidadR;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }
    void Mover()
    {
        horizontal = (Input.GetAxis("Horizontal"));
        vertical = (Input.GetAxis("Vertical"));
        RotarHorizontal = (Input.GetAxis("Mouse X"));


        Vector3 Movimiento = new Vector3(horizontal, 0, vertical);
        Vector3 RotacionX = new Vector3(0, RotarHorizontal , 0);

        transform.Translate(Movimiento * velocidad* Time.deltaTime);
        transform.Rotate(RotacionX * velocidadR);
    }
}
