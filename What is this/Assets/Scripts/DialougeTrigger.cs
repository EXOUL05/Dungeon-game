using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
    public ObjectDialouge dialogue;
    private bool triggered;
    public PlayerMovement movement;
    public bool istalking = false;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialoueScript>().StartDialogue(dialogue);
        movement = FindObjectOfType<PlayerMovement>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered == true)
        {
            TriggerDialogue();
            Invoke("Talking", 1f);
            movement.enabled = false;
            
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggered = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            triggered = false;
            istalking = false;
        }
    }
    void Talking()
    {
        istalking = true;
    }
}
