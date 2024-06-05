using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    public static Stats_Player Instance;
    public static float vida = 100f;
    public static float vidaMaxima = 100f;

    public static float puntos = 0;

    public GameObject panelMuerte;
    public GameObject panelPausa;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "AtaqueEnemigoRake")
        {
            vida = vida - 1;


            if (vida == 0)
            {
                panelMuerte.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (other.transform.tag == "AtaqueEnemigoLizard")
        {
            vida = vida - 5;


            if (vida == 0)
            {
                panelMuerte.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelPausa.SetActive(true);
        }

    }
    public void PararTiempo()
    {
        Time.timeScale = 0;
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
