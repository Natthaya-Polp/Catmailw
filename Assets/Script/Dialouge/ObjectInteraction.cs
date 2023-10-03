using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public DialougeManagerTest dialougeManagerTest;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange &&!hasEnteredCollider)
        {
            dialougeManagerTest.StartDialogue();
            hasEnteredCollider = true;

        }
        else
        {
            
            
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialougeManagerTest.EndDialogue();

        }
    }
}
