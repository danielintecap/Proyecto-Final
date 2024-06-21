using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpiderGreen : MonoBehaviour
{
    public GameObject SpiderGreen;
    public void DestruirAraña()
    {
        Destroy(SpiderGreen, 0.1f);
    }
}
