using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;
    public Text NameText;
    public Text DialogueText;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StarDialogo(Dialogue dialogo)
    {
        NameText.text = dialogo.name;
        sentences.Clear();

        foreach (string sentence in dialogo.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNetSentences();
    }

    public void DisplayNetSentences()
    {
        if(sentences.Count == 0)
        {
            return;
        }

        string sentence = sentences.Dequeue();
        DialogueText.text = sentence;

    }
}
