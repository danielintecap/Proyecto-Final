using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Look : MonoBehaviour
{
    public float mouseSensivility = 100f;
    public Transform PlayerBody;

    public float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility * Time.deltaTime;

        xRotation -= mouseY;    
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
