using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suscriptores_Eventos : MonoBehaviour
{
    public GameObject Objeto;
    public GameObject Enemigo;
    public Vector3 escala;
    public Vector3 escalaenemigo;

    public void EscalaObjeto()
    {
        Objeto.transform.localScale = escala;
    }

    public void EscalaEnemigo()
    {
        Enemigo.transform.localScale = escalaenemigo;
    }
}
