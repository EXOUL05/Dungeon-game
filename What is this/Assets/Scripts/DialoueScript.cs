using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialoueScript : MonoBehaviour
{
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI dtext;
    private Queue<string> sentences;
    public int sentencesCount;
    public GameObject ContinueBtn;
    public PlayerMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void Update()
    {
        sentencesCount = sentences.Count;
    }
    public void StartDialogue(ObjectDialouge dialouge)
    {
        nametext.text = dialouge.name + ":";

        sentences.Clear();
        foreach (string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
            ContinueBtn.SetActive(true);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dtext.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dtext.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        movement.enabled = true;
        nametext.text = "";
        dtext.text = "";
        ContinueBtn.SetActive(false);
    }

}
