using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpiderGreen : MonoBehaviour
{
    public GameObject SpiderGreen;
    public void DestruirAraņa()
    {
        Destroy(SpiderGreen, 0.1f);
    }
}
