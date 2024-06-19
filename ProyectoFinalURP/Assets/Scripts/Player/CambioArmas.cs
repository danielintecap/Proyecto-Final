using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioArmas : MonoBehaviour
{
    public GameObject arma1;
    public GameObject arma2;
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
            animator.SetBool("CambioArma", false);
            arma1.SetActive(true);
            arma2.SetActive(false);
        }
        if (Input.GetKeyDown("2"))
        {
            animator = GetComponentInChildren<Animator>();
            animator.SetBool("CambioArma", true);
            arma1.SetActive(false);
            arma2.SetActive(true);
        }
    }
}
