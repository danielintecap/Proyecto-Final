using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_PJs : MonoBehaviour
{
    public GameObject Chloe;
    public GameObject DJ;
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
        if (Input.GetKeyDown("1"))
        {
            animator = GetComponentInChildren<Animator>();
            Chloe.SetActive(true);
            DJ.SetActive(false);
            Luis.SetActive(false);
            //IA
            IA_Chloe.SetActive(false);
            IA_DJ.SetActive(true);
            IA_Luis.SetActive(true);
        }

        if (Input.GetKeyDown("2"))
        {
            animator = GetComponentInChildren<Animator>();
            Chloe.SetActive(false);
            DJ.SetActive(true);
            Luis.SetActive(false);
            //IA
            IA_Chloe.SetActive(true);
            IA_DJ.SetActive(false);
            IA_Luis.SetActive(true);
        }

        if (Input.GetKeyDown("3"))
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
