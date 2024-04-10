using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_PJs : MonoBehaviour
{
    public GameObject Chloe;
    public GameObject DJ;
    public GameObject Luis;
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
        }

        if (Input.GetKeyDown("2"))
        {
            animator = GetComponentInChildren<Animator>();
            Chloe.SetActive(false);
            DJ.SetActive(true);
            Luis.SetActive(false);
        }

        if (Input.GetKeyDown("3"))
        {
            animator = GetComponentInChildren<Animator>();
            Chloe.SetActive(false);
            DJ.SetActive(false);
            Luis.SetActive(true);
        }
    }
}
