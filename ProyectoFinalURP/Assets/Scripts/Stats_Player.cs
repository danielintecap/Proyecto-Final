using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida = 100f;
    public GameObject panel;


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

}
