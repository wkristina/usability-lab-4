using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Quelle: https://github.com/Brackeys/Dialogue-System


public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;

    private Queue<string> sentences;

    public DialogueManager(Text dialogueText)
    {
        this.dialogueText = dialogueText;
    }

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("starting a conversation with " + dialogue.name);
        string name = dialogue.name;
        Debug.Log("Der Name ist " + name);


        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();

        if (dialogueText == null)
        {
            Debug.Log("dialogueText is null");
            Debug.Log("The sentece is " + sentence);
        }
        else
        {
            dialogueText.text = sentence;
        }
    }

    public void EndDialogue()
    {
        Debug.Log("End of dialogue");
    }
}
