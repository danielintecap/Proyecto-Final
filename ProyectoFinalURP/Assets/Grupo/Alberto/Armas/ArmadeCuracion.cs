using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmadeCuracion : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Direccion;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direccion * speed * Time.deltaTime);
    }
}
