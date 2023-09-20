using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManagerTest : MonoBehaviour
{
    public Text dialogueText;
    public GameObject dilogueBg;
    public string[] dialogueLines; // An array to hold your dialogue lines.
    private int currentLine = 0;
    private bool dialogueActive = false;



    void Start()
    {
        dialogueText.gameObject.SetActive(false);
        dilogueBg.SetActive(false);
    }

    void Update()
    {
        if (dialogueActive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextLine();
            }
        }
    }

    public void StartDialogue()
    {
        currentLine = 0;
        dialogueActive = true;
        dialogueText.gameObject.SetActive(true);
        dilogueBg.SetActive(true);
        NextLine();
    }

    public void NextLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
            currentLine++;
        }
        else
        {
            EndDialogue();
        }
    }

    public void EndDialogue()
    {
        dialogueText.gameObject.SetActive(false);
        dilogueBg.SetActive(false);
        dialogueActive = false;

    }




}
