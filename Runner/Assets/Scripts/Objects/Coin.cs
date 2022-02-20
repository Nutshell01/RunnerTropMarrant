using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 15f;

    CoinMove coinMoveScript;
    Collider coinCollider;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        coinCollider = GetComponent<Collider>();
        coinMoveScript = gameObject.GetComponent<CoinMove>();
        coinMoveScript.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin Detector")
        {
            coinCollider.isTrigger = false;
            coinMoveScript.enabled = true;
        }
    }
}
