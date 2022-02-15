using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleImpact : MonoBehaviour
{
    ParticleSystem _playerDeathParticles;

    PlayerDeath _playerScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            _playerDeathParticles = other.GetComponentInChildren<ParticleSystem>();
            _playerScript = other.GetComponent<PlayerDeath>();
            _playerScript._playerDeath.Invoke();
        }
    }


}
