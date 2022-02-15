using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetCoins : MonoBehaviour
{
    public float MagnetDuration = 0f;
    public Collider Collider;

   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            Collider.enabled = false;
            SuperJumpDuration = 15f;
        }
    }

    private void Update()
    {
        if (SuperJumpDuration != 0)
        {
            SuperJumpDuration = SuperJumpDuration - 1f * Time.deltaTime;
        }

        if (SuperJumpDuration <= 0)
        {
            playermovements.jumpForce = 5f;
        }


    }*/
}
