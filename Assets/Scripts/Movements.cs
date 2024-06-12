using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.SetBool("IsRunning", true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsRunning", false);
            animator.SetTrigger("Jump");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetBool("IsRunning", false);
            animator.SetTrigger("Duck");
        }
    }

    public void OnComplete()
    {
        animator.SetBool("IsRunning", true);
    }


}
