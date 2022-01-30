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
    // private void Update()
    // {
        
    //     _worldObject = GameObject.FindGameObjectsWithTag("Generated");

    // }
    private void FixedUpdate()
    {
        // for (int i = 0; i > _worldObject.Length +1 ; i++)
        // {
        //     _worldObject[i].transform.position += -transform.forward * _worldSpeed * Time.deltaTime;
        // }
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
