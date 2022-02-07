using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleImpact : MonoBehaviour
{
    ParticleSystem _playerDeathParticles;
    GameObject _player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            _playerDeathParticles = other.GetComponentInChildren<ParticleSystem>();
            _player = other.gameObject;

            StartCoroutine(PlayerDeath());
        }
    }

    IEnumerator PlayerDeath()
    {
        _playerDeathParticles.Play();

        yield return new WaitForSeconds(0.1f);

        for(int i = 0; i < _player.GetComponentsInChildren<SkinnedMeshRenderer>().Length; i++)
        {
            _player.GetComponentsInChildren<SkinnedMeshRenderer>()[i].enabled = false;
        }
    }
}
