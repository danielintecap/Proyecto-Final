using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFPS_CC : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravedad = -9.8f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.45f;
    public LayerMask groundMask;
    public bool isGrounded;
    public float JumpHeight = 3f;

    public GameObject cam1;
    public GameObject cam2;

    public Animator animator;
    public GameObject balaPlayer;
    public Transform pointerBala;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        CambioCamaras();
    }

    public void CambioCamaras()
    {
        if (Input.GetButton("Fire2"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            GetComponent<TP_Move>().enabled = false;
            Movimiento();
        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            GetComponent<TP_Move>().enabled = true;
        }
    }
    public void Movimiento()
    {
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("Shoot", true);
            Disparo();
        }
        else
        {
            animator.SetBool("Shoot", false);
        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravedad);
        }

        velocity.y += gravedad * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Disparo()
    {
        Instantiate(balaPlayer, pointerBala.position, transform.rotation);
    }
}
