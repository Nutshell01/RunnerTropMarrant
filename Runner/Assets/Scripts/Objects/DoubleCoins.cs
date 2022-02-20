using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleCoins : MonoBehaviour
{
    [SerializeField] private Collectible collectible;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            StartCoroutine(Jump());
        }
    }

    IEnumerator Jump()
    {
        Destroy(transform.GetChild(0).gameObject);
        collectible._coinValue = 2;
        yield return new WaitForSeconds(30f);
        collectible._coinValue = 1;
    }


}
