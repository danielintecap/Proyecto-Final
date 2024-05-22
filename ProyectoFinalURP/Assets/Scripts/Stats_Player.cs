using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida = 100f;
    public GameObject panel;
    public static float vidaMaxima = 100f;


    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "AtaqueEnemigoRake")
        {
            vida = vida - 1;


            if (vida == 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (other.transform.tag == "AtaqueEnemigoLizard")
        {
            vida = vida - 5;


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
