using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private PlayerAnimations playerAnimations;

     public Transform[] transforms;
     //private bool _right;

     public float jumpForce;
     Rigidbody rb;

    public float actionDuration = 0.15f;
    public float actionTimeToRemain = 0f;

    public bool isGrounded = true;
    private Vector3 velocity = Vector3.zero;

    private int currentTransform = 1;

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

     }

    private void FixedUpdate()
    {
        float HorizontalMovement = Mathf.MoveTowards(0, transforms[currentTransform].position.x - rb.position.x, 0.5f);
        velocity.x = HorizontalMovement / Time.deltaTime;

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

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

    public void Slide()
    {
        if (actionTimeToRemain <= 0)
        {
            playerAnimations.OnSlide();
            actionTimeToRemain = actionDuration;
        }

    }

    public void Left()
    {
        if(actionTimeToRemain <= 0  && moveToLeft())
        {
            actionTimeToRemain = actionDuration;
        }
    }

    public void Right()
    {
        if (actionTimeToRemain <= 0 && moveToRight())
        {
            actionTimeToRemain = actionDuration;
        }
    }

    public bool moveToLeft()
    {
        if(currentTransform == 0)
        {
            return false;
        }
        playerAnimations.OnLeft();

        currentTransform -= 1;
        return true;
    }

    public bool moveToRight()
    {
        if (currentTransform == 2)
        {
            return false;
        }
        playerAnimations.OnRight();
        currentTransform += 1;
        return true;
    }

    /*public void SetRightBool(bool boolToSet)
     {
         _right = boolToSet;
     }*/

    
}
