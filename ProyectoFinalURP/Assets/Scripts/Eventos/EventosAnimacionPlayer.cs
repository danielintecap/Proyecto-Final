using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosAnimacionPlayer : MonoBehaviour
{
    public AudioSource Source;
    public Transform PointerParticulas;
    public AudioClip ClipAtack;
    public AudioClip ClipRun;
    public AudioClip ClipWalk;
    public AudioClip ClipJump;
    public AudioClip ClipLand;
    public GameObject particulaAtaque;
    public GameObject particulaCorrer;

    public void EfectoAtaque()
    {
        Source.PlayOneShot(ClipAtack);
        Instantiate(particulaAtaque, PointerParticulas);
    }
    public void EfectoCorrer()
    {
        Source.PlayOneShot(ClipRun);
        Instantiate(particulaCorrer, PointerParticulas);
    }
    public void EfectoCaminar()
    {
        Source.PlayOneShot(ClipWalk);
    }
    public void EfectoSaltar()
    {
        Source.PlayOneShot(ClipJump);
    }
    public void EfectoAterrizar()
    {
        Source.PlayOneShot(ClipLand);
    }
}
