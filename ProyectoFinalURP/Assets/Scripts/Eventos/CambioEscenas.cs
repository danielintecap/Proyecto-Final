using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioEscenas : MonoBehaviour
{
    public GameObject Paneloptions;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MenuOptions()
    {
        Paneloptions.SetActive(true);
    }

    public void MenuOptionsClose()
    {
        Paneloptions.SetActive(false);
    }

    public void CargarEscenaLobby()
    {
        SceneManager.LoadScene(1);
    }
    public void CargarEscenaNido1()
    {
        SceneManager.LoadScene(2);
    }
    public void CargarEscenaNido2()
    {
        SceneManager.LoadScene(3);
    }
    public void CargarEscenaCentralElectrica()
    {
        SceneManager.LoadScene(4);
    }
    public void CargarEscenaNido3()
    {
        SceneManager.LoadScene(5);
    }
    public void CargarEscenaLaboratorio()
    {
        SceneManager.LoadScene(0);
    }
    public void GameExit()
    {
        Application.Quit();
    }
    public void Reintentar()
    {
        Time.timeScale = 1;
    }
}
