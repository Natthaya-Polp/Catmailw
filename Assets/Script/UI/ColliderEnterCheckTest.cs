using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnterCheckTest : MonoBehaviour
{
    private bool hasEnteredCollider = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasEnteredCollider)
        {
            // Debug your message or do other actions here.
            Debug.Log("Player entered the collider for the first time!");

            // Set the boolean to true so it won't debug again.
            hasEnteredCollider = true;
        }
    }

}
