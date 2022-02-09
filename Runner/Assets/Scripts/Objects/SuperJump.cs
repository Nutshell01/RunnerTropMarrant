using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJump : MonoBehaviour
{
    [SerializeField] private PlayerMovements playermovements;

    public float actionDuration = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            //Destroy(gameObject);

            if(actionDuration !>= 0)
            {
                playermovements.jumpForce = 10f;
            }
        }
    }

    private void Update()
    {
        if(actionDuration !=0)
        {
            actionDuration = actionDuration - 0.1f * Time.deltaTime;
        }
        
    }
}
