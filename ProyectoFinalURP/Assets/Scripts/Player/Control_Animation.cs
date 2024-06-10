using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Animation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    const float AnimationTime = 0.05f;
    
    void Start()    
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator = GetComponentInChildren<Animator>();
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0f, z);
        float Magnitud = Mathf.Clamp01(move.magnitude);

        if(Input.GetKey(KeyCode.LeftShift)||Input.GetKey(KeyCode.RightShift))
        {
            Magnitud /= 0.5f;
        }

        animator.SetFloat("SpeedPercent", Magnitud, AnimationTime, Time.deltaTime);
    }
}
