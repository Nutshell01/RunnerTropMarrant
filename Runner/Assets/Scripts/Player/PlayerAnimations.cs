using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator = null;

    private static int zProperty = Animator.StringToHash("z");

    private void LateUpdate()
    {
        
    }
}
