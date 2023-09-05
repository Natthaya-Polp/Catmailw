using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    [SerializeField]private GameObject dialogue;

    public void ActivatedDialogue(){
        dialogue.SetActive(true);
    }

    public bool dialogueActive(){
        return dialogue.activeInHierarchy;
    }

}
