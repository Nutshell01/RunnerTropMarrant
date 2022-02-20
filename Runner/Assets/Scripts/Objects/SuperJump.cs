using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJump : MonoBehaviour
{
    public Transform playerTransform;
    PlayerMovements playerMovementsScript;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        playerMovementsScript = playerTransform.GetComponent<PlayerMovements>();
    }
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
        playerMovementsScript.jumpForce = 10.5f;
        yield return new WaitForSeconds(15f);
        playerMovementsScript.jumpForce = 8f;
    }

}
