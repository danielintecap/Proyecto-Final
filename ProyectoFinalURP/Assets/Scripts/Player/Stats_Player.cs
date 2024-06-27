using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static float vida = 100f;
    public static float vidaMaxima = 100f;
    public static float puntos;

    public GameObject panelMuerte;
    public GameObject panelPausa;
    public GameObject mapa;
    public GameObject panelPersonajes;


    [SerializeField]public static float Enemigos = 20f;

    public void Update()
    {
        Pausa();
    }

    public void Pausa()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelPausa.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            mapa.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            panelPersonajes.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "AtaqueEnemigoRake")
        {
            vida = vida - 0.1f;


            if (vida == 0)
            {
                panelMuerte.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (other.transform.tag == "AtaqueEnemigoLizard")
        {
            vida = vida - 0.1f;


            if (vida == 0)
            {
                panelMuerte.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (other.transform.tag == "AtaqueEnemigoSpiderGreen")
        {
            vida = vida - 0.1f;


            if (vida == 0)
            {
                panelMuerte.SetActive(true);
                Time.timeScale = 0;
            }
        }

    }
    public void RecibirCura(float cura)

    {
        vida += cura;

        if (vida > vidaMaxima)
        {
            vida = vidaMaxima;
        }

    }
}
