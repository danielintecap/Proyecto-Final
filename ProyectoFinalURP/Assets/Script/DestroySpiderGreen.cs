using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpiderGreen : MonoBehaviour
{
    public GameObject SpiderGreen;
    public void DestruirAra�a()
    {
        Destroy(SpiderGreen, 0.1f);
    }
}
