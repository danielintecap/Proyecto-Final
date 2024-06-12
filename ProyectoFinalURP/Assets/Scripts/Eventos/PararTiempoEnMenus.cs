using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararTiempoEnMenus : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelPausa;
    public GameObject panelTienda;
    public GameObject panelLab;
    public GameObject panelNido1;
    public GameObject panelNido2;
    public GameObject panelCentralElectrica;

    // Update is called once per frame
    void Update()
    {
        if(panelInicio == true)
        {
            PararTiempo();
        } 
        if (panelPausa == true)
        {
            PararTiempo();
        }
        if (panelTienda == true)
        {
            PararTiempo();
        }
        if (panelLab == true)
        {
            PararTiempo();
        }
        if (panelNido1 == true)
        {
            PararTiempo();
        }
        if (panelNido2 == true)
        {
            PararTiempo();
        }
        if (panelCentralElectrica == true)
        {
            PararTiempo();
        }
    }
    void PararTiempo()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 0;
    }
    void ReestablecerTiempo()
    {
        Time.timeScale = 1;
    }
}
