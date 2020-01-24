using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputCheck : MonoBehaviour
{
    
    public TMP_InputField input;
    private string inputVal;
    
    public string secretCode;

    public GameObject itemToShow;
    
    
    public DialougeTrigger dialougeTrigger;
    public DialoueScript dialoueScript;
    public Animator anim;
    public GameObject questionScreen;
    public BoxCollider2D boxCollider;

    public void Start()
    {
        
    }

    private void Update()
    {
        input.characterLimit = secretCode.Length;
        inputVal = input.text.ToUpper();

        if (dialougeTrigger.istalking == true)
        {
            if (dialoueScript.sentencesCount <= 1)
            {
                questionScreen.SetActive(true);
                
                
            }
        }
    }
    public void Correct()
    {
        itemToShow.SetActive(true);
        boxCollider.enabled = false;
        Destroy(gameObject, 1.5f);
        anim.SetBool("isTrue", true);
    }

    void Effects()
    {
        anim.SetBool("isTrue", false);
    }
    public void SubmitButton()
    {

        if (inputVal == secretCode)
        {
            
            Correct();
            Invoke("Effects", 1f);
        }
        if (inputVal != secretCode || inputVal == null)
        {
            questionScreen.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        

        questionScreen.SetActive(false);

    }
}
