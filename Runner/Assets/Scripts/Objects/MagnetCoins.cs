using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetCoins : MonoBehaviour
{
    public Transform playerTransform;
    GameObject coinDetectorObject;

    private void Start()
    {
        playerTransform = GameObject.FindObjectOfType<Collectible>().transform;
        coinDetectorObject = playerTransform.GetChild(4).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            Debug.Log(coinDetectorObject);
            StartCoroutine(ActivateCoin());
        }
    }

    IEnumerator ActivateCoin()
    {
        Destroy(transform.GetChild(0).gameObject);
        coinDetectorObject.gameObject.SetActive(true);
        yield return new WaitForSeconds(30f);
        coinDetectorObject.gameObject.SetActive(false);
    }


}
