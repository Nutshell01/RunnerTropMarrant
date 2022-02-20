using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJump : MonoBehaviour
{
    [SerializeField] private PlayerMovements playermovements;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
           StartCoroutine(Jump());
        }
    }

    IEnumerator Jump()
    {
        Destroy(transform.GetChild(0).gameObject);
        playermovements.jumpForce = 10f;
        yield return new WaitForSeconds(30f);
        playermovements.jumpForce = 8f;
    }

}
