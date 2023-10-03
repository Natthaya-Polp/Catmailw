using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectHouse : MonoBehaviour
{
    [SerializeField] GameObject happy;
    [SerializeField] GameObject angry;
    [SerializeField] GameObject Gameover;

    public bool isCorrect;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public int moodPoint = 5;
    public int currentPoint;

    private void Start()
    {
        currentPoint = moodPoint;
        UpdateMoodUi();
    }
    public void Update()
    {
        if (playerInRange && isCorrect && Input.GetKeyDown(KeyCode.E) && !hasEnteredCollider)
        {
            currentPoint++;
            Debug.Log(currentPoint);
            UpdateMoodUi();
            hasEnteredCollider = true;

        }
        else
        {

        }
    }

    void UpdateMoodUi()
    {
        if (currentPoint >= 5)
        {
            happy.SetActive(true);
        }
        else if (currentPoint >= 3 && currentPoint < 5)
        {
            angry.SetActive(true);
        }
        else if (currentPoint < 2)
        {
            Gameover.SetActive(true);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isCorrect = true;
            playerInRange = true;

        }
        else
        {

        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        playerInRange = false;
    }
}
