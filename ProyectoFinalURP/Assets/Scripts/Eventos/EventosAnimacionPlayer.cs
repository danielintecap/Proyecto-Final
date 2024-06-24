using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosAnimacionPlayer : MonoBehaviour
{
    public AudioSource Source;
    public Transform PointerParticulas;
    public AudioClip ClipAtack;
    public AudioClip ClipAtack2;
    public AudioClip ClipRun;
    public AudioClip ClipWalk;
    public AudioClip ClipJump;
    public AudioClip ClipLand;
    public GameObject particulaAtaque;
    public GameObject particulaAtaque2;

    public void EfectoAtaque()
    {
        Source.PlayOneShot(ClipAtack);
        Instantiate(particulaAtaque, PointerParticulas);
    }
    public void EfectoAtaque_2()
    {
        Source.PlayOneShot(ClipAtack2);
        Instantiate(particulaAtaque2, PointerParticulas);
    }
    public void EfectoCorrer()
    {
        Source.PlayOneShot(ClipRun);
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
