using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private int jump = Animator.StringToHash("jump");
    private int slide = Animator.StringToHash("slide");

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


}
