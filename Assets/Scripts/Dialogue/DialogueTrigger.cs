using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue() //This is triggered when the start dialogue button is pressed
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
