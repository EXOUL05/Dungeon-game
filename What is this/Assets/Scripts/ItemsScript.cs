using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsScript : MonoBehaviour
{

    public Animator anim;
    public TextMeshProUGUI textMeshPro;
    public GameObject questionPanel;
    public DialoueScript dialoueScript;
    public YesNoQuestion yesNo;
    public string question;
    public DialougeTrigger dialougeTrigger;
    public bool isKey;
    public LockScript lockScript;
    public FindObjectScript findObject;
    

    private void Update()
    {
        if (dialougeTrigger.istalking == true)
        {
            if (dialoueScript.sentencesCount <= 0)
            {
                questionPanel.SetActive(true);
                textMeshPro.text = question;

            }
        }
       
        if (yesNo.acceptaVal == 1)
        {

            anim.SetBool("isTrue", true);
            Invoke("Effects", 1f);
            questionPanel.SetActive(false);
            findObject.gb.SetActive(false);
            
            if(isKey == true)
            {
                lockScript.isLocked = false;
            }
            

        }
        if (yesNo.acceptaVal == 2)
        {
            questionPanel.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        yesNo.isBeingUsed = true;
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        yesNo.isBeingUsed = false;
         
        questionPanel.SetActive(false);
        
    }
    void Effects()
    {
        anim.SetBool("isTrue", false);
    }

    

}

