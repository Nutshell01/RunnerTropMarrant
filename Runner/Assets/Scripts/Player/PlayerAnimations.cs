using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator = null;

    private static int zProperty = Animator.StringToHash("z");

    [SerializeField] private PlayerAnimations playerAnimations = null;
    [SerializeField] private PlayerMovements playerMovements = null;

    private void Update()
    {
        animator.SetTrigger(zProperty);
    }
}
