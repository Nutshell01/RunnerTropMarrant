using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetCoins : MonoBehaviour
{
    public float MagnetDuration = 0f;
    public Collider Collider;
    public bool attraction = false;
    public Rigidbody playerRb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            Collider.enabled = false;
            attraction = true;
            MagnetDuration = 15f;

            if(other.gameObject.layer == 10 )
            {
           
            }

            //if(Physics.SphereCast)
            {

            }
        }
    }

    private void Update()
    {
        if (MagnetDuration != 0)
        {
            MagnetDuration = MagnetDuration - 1f * Time.deltaTime;
        }

        if (MagnetDuration <= 0)
        {
            attraction = false;
        }
    }
}
