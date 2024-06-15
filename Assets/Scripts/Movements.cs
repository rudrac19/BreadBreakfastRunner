using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public Animator animator;
    public bool powered = false;

    void Start()
    {
        animator.SetBool("IsRunning", true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("IsRunning", false);
            animator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetBool("IsRunning", false);
            animator.SetTrigger("Duck");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("IsRunning", false);
            animator.SetTrigger("Power");
            powered = true;
        }
    }

    public void OnComplete()
    {
        animator.SetBool("IsRunning", true);
        powered = false;
    }


}
