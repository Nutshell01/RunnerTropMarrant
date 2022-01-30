using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDécors : MonoBehaviour
{
    [SerializeField] float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.forward * _speed * Time.deltaTime;
    }
}
