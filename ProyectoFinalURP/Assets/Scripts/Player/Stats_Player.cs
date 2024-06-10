using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
<<<<<<< HEAD:ProyectoFinalURP/Assets/Scripts/Stats_Player.cs
    // Start is called before the first frame update
    public float vida = 100f;
    public GameObject panel;
=======
    public static Stats_Player Instance;
    public static float vida = 100f;
    public static float vidaMaxima = 100f;
>>>>>>> 6eaefc1489d310dbbd21bd4944784680353e9a9c:ProyectoFinalURP/Assets/Scripts/Player/Stats_Player.cs

    public static float puntos = 0;

    public GameObject panelMuerte;
    public GameObject panelPausa;
    public GameObject panelInicio;

    public void Update()
    {
        Pausa();
    }
    public void Pausa()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelPausa.SetActive(true);
            panelInicio.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelPausa.SetActive(true);
            panelInicio.SetActive(true);
        }*/
        
        if (other.transform.tag == "AtaqueEnemigoRake")
        {
            vida = vida - 0.5f;


            if (vida == 0)
            {
                panelMuerte.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (other.transform.tag == "AtaqueEnemigoLizard")
        {
            vida = vida - 0.5f;


            if (vida == 0)
            {
                panelMuerte.SetActive(true);
                Time.timeScale = 0;
            }
        }

        

    }
    public void PararTiempo()
    {
        Time.timeScale = 0;
    }

<<<<<<< HEAD:ProyectoFinalURP/Assets/Scripts/Stats_Player.cs
=======
    public void RecibirCura(float cura)
    {
        vida += cura;

        if (vida > vidaMaxima)
        {
            vida = vidaMaxima;
        }
    }
>>>>>>> 6eaefc1489d310dbbd21bd4944784680353e9a9c:ProyectoFinalURP/Assets/Scripts/Player/Stats_Player.cs
}
