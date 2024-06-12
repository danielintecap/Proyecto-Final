using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConteoEnemigos : MonoBehaviour
{
    // Start is called before the first frame update
    public static int CETRake = 2;
    //public static int CETLizard = 1;
    //public static int CETSpiderGreen = 1;
    public GameObject Ganaste;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemigoTipoAliens();
    }

    void EnemigoTipoAliens()
    {
        if(CETRake == 0)
        {
            Ganaste.SetActive(true);
        }
    }
}
