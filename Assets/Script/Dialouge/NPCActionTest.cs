using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCActionTest : MonoBehaviour
{
    public DialougeManagerTest dialougeManagerTest;
    private bool hasEnteredCollider = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasEnteredCollider)
        {
            dialougeManagerTest.StartDialogue();
            hasEnteredCollider = true;

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
