using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstHouse : MonoBehaviour
{
    private bool hasEnteredCollider = false;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && playerInRange && !hasEnteredCollider)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
                hasEnteredCollider = true;
            }
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
        if (other.CompareTag("Player") )
        {
            playerInRange = false;
            dialogBox.SetActive(false);
           
        }
    }
}
