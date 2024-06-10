using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    float RotarVertical;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotarVertical = (Input.GetAxis("Mouse Y"));
        Vector3 RotacionY = new Vector3(-RotarVertical, 0, 0);
        transform.Rotate(RotacionY);
    }
}
