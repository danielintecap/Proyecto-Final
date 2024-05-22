using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int vida = 100;
    public GameObject panel;


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

}
