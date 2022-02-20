using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    public UnityEvent _playerDeath;

    [SerializeField] GameManager _gameManager;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _GameOverUi;
    [SerializeField] ObjectCreator _objectCreator;
    [SerializeField] ParticleSystem _playerDeathParticles;
    [SerializeField] PlayerInputs _playerInputs;
    [SerializeField] Rigidbody _rb;
    [SerializeField] AudioSource _deathsound;

    public void OnDeath()
    {
        _playerDeathParticles.Play();
        _deathsound.Play();
        _rb.isKinematic = true;
        _playerInputs.enabled = false;
        _gameManager._isDead = true;
        _GameOverUi.SetActive(true);
        _objectCreator.EndTimer();
        _player.SetActive(false);
    }

}




