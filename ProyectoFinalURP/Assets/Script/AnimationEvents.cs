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
    public AudioSource Source;
    public AudioClip ClipIdle;
    public AudioClip ClipWatch;
    public AudioClip ClipWalk;
    public AudioClip ClipAttack;

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

    public void EfectoIdle()
    {
        Source.PlayOneShot(ClipIdle);
    }

    public void EfectoWalk()
    {
        Source.PlayOneShot(ClipWatch);
        Source.PlayOneShot(ClipWalk);
    }

    public void EfectoAttack()
    {
        Source.PlayOneShot(ClipAttack);
    }
}
