using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapscript : MonoBehaviour
{
    public float timeToFire;
    private float timetoFireVal;
    CircleCollider2D circleCollider;
    Animator animator;
    public float courotineTime;
    public GameObject lights;

    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        animator = GetComponent<Animator>();
        timetoFireVal = timeToFire;
        circleCollider.enabled = false;
        lights.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timetoFireVal -= Time.deltaTime;

        if (timetoFireVal <= 0f)
        {
            circleCollider.enabled = true;
            animator.SetBool("isFiring", true);
            lights.SetActive(true);
            StartCoroutine(Firing());
        }
        
    }
    IEnumerator Firing()
    {
        yield return new WaitForSeconds(courotineTime);
        lights.SetActive(false);
        animator.SetBool("isFiring", false);
        circleCollider.enabled = false;
        timetoFireVal = timeToFire;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Do Damage Here
            //Effects here
            Debug.Log("Damaged");
        }
    }
}
