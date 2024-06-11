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
            animator.SetTrigger("Jump");
            animator.SetBool("IsRunning", false);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Duck");
            animator.SetBool("IsRunning", false);
        }
        else
        {
            animator.SetBool("IsRunning", true);
        }

    }
}
