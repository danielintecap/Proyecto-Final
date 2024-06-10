using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpiderGreen : MonoBehaviour
{
    public void DestruirAraña()
    {
        Destroy(gameObject, 0.1f);
    }
}
