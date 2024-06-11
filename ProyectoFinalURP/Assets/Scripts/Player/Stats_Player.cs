using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static float vida = 100f;
    public static float vidaMaxima = 100f;
    public static float puntos;

    public GameObject panel;
    public GameObject panelPausa;
    public GameObject panelInicio;

    public void Update()
    {
        
    }

    public void Pausa()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelInicio.SetActive(true);
            panelPausa.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "AtaqueEnemigoRake")
        {
            vida = vida - 0.5f;


            if (vida == 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (other.transform.tag == "AtaqueEnemigoLizard")
        {
            vida = vida - 0.5f;


            if (vida == 0)
            {
                panel.SetActive(true);
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
