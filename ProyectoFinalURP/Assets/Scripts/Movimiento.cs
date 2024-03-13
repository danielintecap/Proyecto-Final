using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
    
{
    public float MovHorizontal;
    public float MovVertical;
    public float velocidad;
    public float RotacionX;
    public float RotacionY;
    public GameObject camara;
    public float sensivity;
    public float escala;
    public int puntos;

    // Start is called before the first frame update
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
        MovHorizontal = Input.GetAxis("Horizontal");
        MovVertical = Input.GetAxis("Vertical");
        RotacionX = Input.GetAxis("Mouse X");
        RotacionY = Input.GetAxis("Mouse Y");
        Vector3 Movimiento = new Vector3(MovHorizontal, 0, MovVertical);
        Vector3 Rotacion = new Vector3(0, RotacionX, 0);
        Vector3 RotacionCamara = new Vector3(RotacionY, 0, 0);

        transform.Translate(Movimiento * velocidad);
        transform.Rotate(Rotacion);
        camara.transform.Rotate(RotacionCamara * sensivity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Moneda")
        {
            puntos = puntos + 1;
            Destroy(collision.transform.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.name == "veneno")
        {
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "veneno")
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
