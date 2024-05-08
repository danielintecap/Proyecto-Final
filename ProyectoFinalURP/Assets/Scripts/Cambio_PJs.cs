using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_PJs : MonoBehaviour
{
    public GameObject Chloe, Arco, Ballesta;
    public GameObject DJ, Bazuca, Hacha;
    public GameObject Luis;
    public GameObject IA_Chloe;
    public GameObject IA_DJ;
    public GameObject IA_Luis;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator = GetComponentInChildren<Animator>();
            Chloe.SetActive(true);
            DJ.SetActive(false);
            Luis.SetActive(false);

            //IA
            IA_Chloe.SetActive(false);
            IA_DJ.SetActive(true);
            IA_Luis.SetActive(true);

            //armas
            if (Input.GetKeyDown("1"))
            {
                Arco.SetActive(true);
                Ballesta.SetActive(false);
                animator.SetBool("Boost", false);
            }
            if (Input.GetKeyDown("2"))
            {
                Ballesta.SetActive(true);
                Arco.SetActive(false);
                animator.SetBool("Boost", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator = GetComponentInChildren<Animator>();
            Chloe.SetActive(false);
            DJ.SetActive(true);
            Luis.SetActive(false);

            //IA
            IA_Chloe.SetActive(true);
            IA_DJ.SetActive(false);
            IA_Luis.SetActive(true);

            //armas
            if (Input.GetKey("1"))
            {
                Bazuca.SetActive(true);
                Hacha.SetActive(false);
                animator.SetBool("Boost", false);
            }
            if (Input.GetKey("2"))
            {
                Hacha.SetActive(true);
                Bazuca.SetActive(false);
                animator.SetBool("Boost", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            animator = GetComponentInChildren<Animator>();
            Chloe.SetActive(false);
            DJ.SetActive(false);
            Luis.SetActive(true);

            //IA
            IA_Chloe.SetActive(true);
            IA_DJ.SetActive(true);
            IA_Luis.SetActive(false);
        }
    }
}
