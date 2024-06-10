using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : DestroySpiderGreen
{
    public GameObject ParticulaL;
    public GameObject ParticulaR;
    public GameObject ParticulaSpiderGreen;
    public Transform PointerR;
    public Transform PointerL;
    public Transform PointerSpiderGreen;

    public void InstanciarObjetoParticulaR()
    {
        Instantiate(ParticulaR, PointerR);
    }

    public void InstanciarObjetoParticulaL()
    {
        Instantiate(ParticulaL, PointerL);
    }

    public void InstanciarObjetoParticulaSpiderGreen()
    {
        Instantiate(ParticulaSpiderGreen, PointerSpiderGreen);
        DestruirAraña();
    }
}
