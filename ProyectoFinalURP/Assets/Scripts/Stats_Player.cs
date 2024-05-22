using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static float vida = 100;
    public GameObject panel;
    public static float vidaMaxima = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "BalaEnemigo")
        {
            vida = vida - 10;
            Destroy(collision.transform.gameObject);

            if(vida == 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void VidaVeneno()
    {
        vida = vida - 10;
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
