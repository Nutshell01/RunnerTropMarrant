using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    public UnityEvent _playerDeath;

    AudioSource _jump = null;

    // Dans la void du jump

    void JumpSound()
    {
        _jump.pitch = Random.Range(0.9f, 1.1f);
        _jump.Play();
    }

}




