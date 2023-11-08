using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DialougeManagerTest : MonoBehaviour
{
    public Text dialogueText;
    public GameObject dilogueBg;
    public string[] dialogueLines; // An array to hold your dialogue lines.
    private int currentLine = 0;
    private bool dialogueActive = false;

    public GameObject FinishUI;



    void Start()
    {
        dialogueText.gameObject.SetActive(false);
        dilogueBg.SetActive(false);
        FinishUI.SetActive(false);
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
            StartCoroutine(ShowUI3Second());
            
        }
    }

    public void EndDialogue()
    {
        dialogueText.gameObject.SetActive(false);
        dilogueBg.SetActive(false);
        dialogueActive = false;

        

    }

    IEnumerator ShowUI3Second()
    {
        FinishUI.SetActive(true);

        yield return new WaitForSeconds(2);

        FinishUI.SetActive(false);
    }

 




}
