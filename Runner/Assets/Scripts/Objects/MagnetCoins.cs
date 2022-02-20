using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetCoins : MonoBehaviour
{
    public GameObject coinDetectorObject;

    private void Start()
    {
        coinDetectorObject = GameObject.FindGameObjectWithTag("Coin Detector");
        coinDetectorObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            StartCoroutine(ActivateCoin());
        }
    }

    IEnumerator ActivateCoin()
    {
        Destroy(transform.GetChild(0).gameObject);
        coinDetectorObject.SetActive(true);
        yield return new WaitForSeconds(30f);
        coinDetectorObject.SetActive(false);
    }


}
