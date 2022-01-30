using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private PlayerAnimations playerAnimations;

     public Transform[] transforms;
     private bool _right;

     public float jumpForce;
     Rigidbody rb;

    public float actionDuration = 0.15f;
    public float actionTimeToRemain = 0f;

    public bool isGrounded =true;

     private void Start()
     {
         rb = GetComponent<Rigidbody>();
     }
     private void Update()
     {
        if(actionTimeToRemain != 0)
        {
            actionTimeToRemain = actionTimeToRemain - 0.2f *Time.deltaTime;
        }

        isGrounded = true;
        Movements();
     }

     public void Movements()
     {

     }

     public void Jump()
     {
         Vector3 jumpforce = new Vector3(0, jumpForce, 0);

        if(actionTimeToRemain <= 0 && isGrounded ==true )
        {
            rb.AddForce(jumpforce, ForceMode.Impulse);
            playerAnimations.OnJump();
            isGrounded = false;
            actionTimeToRemain = actionDuration;
        }
    }

     public void SetRightBool(bool boolToSet)
     {
         _right = boolToSet;
     }

    
}
