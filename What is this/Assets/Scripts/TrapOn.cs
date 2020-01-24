using UnityEngine;

public class TrapOn : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isFiring", true);
    }
}
