using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoodedManDisappear : MonoBehaviour
{
    Animator animator;
    public DialoueScript dialoueScript;
    public DialougeTrigger dialougeTrigger;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (dialougeTrigger.istalking == true)
        {
            if (dialoueScript.sentencesCount <= 1)
            {
                Debug.Log(dialoueScript.sentencesCount);
                animator.SetBool("isDisappearing", true);
                Destroy(gameObject, 1f);
            }
        }
       
    }
}
