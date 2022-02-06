using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private int jump = Animator.StringToHash("jump");
    private int slide = Animator.StringToHash("slide");
    private int left = Animator.StringToHash("left");
    private int right = Animator.StringToHash("right");

    [SerializeField] private Animator animator = null;


    private void Start()
    {
        OnRun();
    }
    private void OnRun()
    {
        animator.SetFloat("z", 1.0f);
    }

    public void OnJump()
    {
        animator.SetTrigger(jump);
        OnRun();
    }

    public void OnSlide()
    {
        animator.SetTrigger(slide);
    }

    public void OnLeft()
    {
        animator.SetTrigger(left);
    }

    public void OnRight()
    {
        animator.SetTrigger(right);
    }


}
