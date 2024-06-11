using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue Dialogo;
    public GameObject DialogoAbrir;
    
    public void DialogoTrigger()
    {
        FindObjectOfType<DialogueManager>().StarDialogo(Dialogo);
        DialogoAbrir.SetActive(true);
    }

    public void CerrarDialogo()
    {
        DialogoAbrir.SetActive(false);
    }

}
