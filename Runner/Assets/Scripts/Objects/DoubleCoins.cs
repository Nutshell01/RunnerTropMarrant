using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleCoins : MonoBehaviour
{
    [SerializeField] private Collectible collectible;
    public Collider Collider;
    public float DoubleCoinsDuration = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            Collider.enabled = false;
            DoubleCoinsDuration = 15f;
            collectible._coinValue = 2;
        }
    }

    private void Update()
    {
        if (DoubleCoinsDuration != 0)
        {
            DoubleCoinsDuration = DoubleCoinsDuration - 1f * Time.deltaTime;
        }

        if (DoubleCoinsDuration <= 0)
        {
            collectible._coinValue = 1;
        }


    }
}
