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

    public void CargarEscena1()
    {
        SceneManager.LoadScene(1);
    }
}
