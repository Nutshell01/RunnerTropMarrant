using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _worldSpeed;
    [SerializeField] GameObject[] _worldObject;

    private void Start()
    {
        _worldObject = GameObject.FindGameObjectsWithTag("Generated");
    }
  
    private void FixedUpdate()
    {
       
        foreach (GameObject worldObj in _worldObject )
        {
            if(worldObj != null)
            worldObj.transform.position += -transform.forward * _worldSpeed * Time.deltaTime;
        }
    }

    public void GetWorldObject()
    {
        _worldObject = GameObject.FindGameObjectsWithTag("Generated");
        Debug.Log("test");
    }
}
