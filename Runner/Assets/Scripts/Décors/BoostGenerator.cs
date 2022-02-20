using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] _boosts;
    private int randomTest;
    [SerializeField] int _spawnCap;
    // Start is called before the first frame update
    void Start()
    {
        randomTest = Random.Range(0,101);
        Debug.Log(randomTest);
        if(randomTest <= _spawnCap)
        {
            GenerateBoost();
        }
    }
    void GenerateBoost()
    {
        int RandomInt = Random.Range(0, _boosts.Length);
        GameObject _objectToGenerate = _boosts[RandomInt];
        GameObject objectGenerated = GameObject.Instantiate(_objectToGenerate, transform.position, Quaternion.identity);
        objectGenerated.transform.parent = this.gameObject.transform;

    }
}
