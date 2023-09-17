using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCActionTest : MonoBehaviour
{
    public DialougeManagerTest dialougeManagerTest;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialougeManagerTest.StartDialogue();
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialougeManagerTest.EndDialogue();
        }
    }
}
