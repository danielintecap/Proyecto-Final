using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Move : MonoBehaviour
{
    //Variables para la gravedad y salto
    public CharacterController controller;
    public float speed = 6f;
    public float gravedad = -9.8f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.45f;
    public LayerMask groundMask;
    public bool isGrounded;
    public float JumpHeight = 2f;

    //Variables para el movimiento de la camara en 3ra 
    public float TurnSmoothTime = 0.1f;
    public float TurnSmoothVelocity;
    public Transform camara;

    Animator animator;
    bool isJump;
    bool isGround;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //Movimiento Camara 3ra persona
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camara.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.localEulerAngles.y, targetAngle, ref TurnSmoothVelocity, TurnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moverDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moverDir.normalized * speed * Time.deltaTime);
        }

        //Gravedad y Salto
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            animator.SetBool("IsGrounded", true);
            isGround = true;
            animator.SetBool("IsJumping", false);
            isJump = false;
        }
        else
        {
            animator.SetBool("IsGrounded", false);
            isGround = false;

            if((isJump && velocity.y < 0))
            {
                animator.SetBool("IsFalling", true);
            }
        }


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravedad);
            animator.SetBool("IsJumping", true);
            isJump = true;
        }

        velocity.y += gravedad * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20f;
        }
        else
        {
            speed = 10f;
        }
    }
}
