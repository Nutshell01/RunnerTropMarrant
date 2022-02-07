using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    GameManager _gameManager;
    public int _coinValue;

    private void Start()
    {
        _gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            _gameManager.SetCollectibleNumber(_coinValue);
        }
    }
}
