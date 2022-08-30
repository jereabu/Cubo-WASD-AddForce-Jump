using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject UIElements;
    [SerializeField] Text dialogueTxt;
    [SerializeField] string[] NPCDialogue;
    [SerializeField] NPCDialogue NPCDialogueScripts;
    public int dialogueIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        NPCDialogueScripts = other.gameObject.GetComponent<NPCDialogue>();
        if (other.gameObject.CompareTag("NPC"))
        {
            UIElements.SetActive(true);
            NPCDialogue = NPCDialogueScripts.data.dialogueLines;
            ShowNextDialogueLine();
        }
    }
    void OnTriggerExit(Collider other)
    {
        dialogueIndex = 0;
        if (other.gameObject.CompareTag("NPC"))
        {
            UIElements.SetActive(false);
            
        }
    }
    public void ShowNextDialogueLine()
    {
        
        if (dialogueIndex < NPCDialogue.Length)
        {
            dialogueTxt.text = NPCDialogue[dialogueIndex];
            dialogueIndex++;
        }
        else
        {

        }
    } 
}
