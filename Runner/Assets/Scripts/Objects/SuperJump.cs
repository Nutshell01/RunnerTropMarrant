using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJump : MonoBehaviour
{
    [SerializeField] private PlayerMovements playermovements;

    public float actionDuration = 1f;

    public float SuperJumpDuration = 0f;
    public Collider Collider;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            Collider.enabled = false;

            if (actionDuration !>= 0)
            {
                playermovements.jumpForce = 10f;
                SuperJumpDuration = 15f;
            }
        }
    }

    private void Update()
    {
        if(actionDuration !=0)
        {
            actionDuration = actionDuration - 0.1f * Time.deltaTime;
        }

        if (SuperJumpDuration != 0)
        {
            SuperJumpDuration = SuperJumpDuration - 1f * Time.deltaTime;
        }

        if (SuperJumpDuration <= 0)
        {
            playermovements.jumpForce = 5f;
        }


    }
}
