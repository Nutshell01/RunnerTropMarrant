using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{

    [SerializeField] GameObject _objectGenerated;
    [SerializeField] GameManager _gameManager;
    [SerializeField] float _timerDuration;
    [SerializeField] GameObject[] _prefabsToInstantiate;
    private float _generationCooldown;
    
    
    

    private void Awake()
    {
        _objectGenerated = GameObject.FindGameObjectWithTag("Generated");
    }
 
    void Update()
    {
        _generationCooldown -= Time.deltaTime;
        Timer();
        //IncreaseTimerDuration();

       
    }
    void Generate()
    {
        GetPositionToGenerate();
        int RandomInt = Random.Range(0, _prefabsToInstantiate.Length);
        GameObject _objectToGenerate = _prefabsToInstantiate[RandomInt];


        GameObject objectGenerated = GameObject.Instantiate(_objectToGenerate, GetPositionToGenerate(), Quaternion.identity);

        _objectGenerated = objectGenerated;
        _gameManager.GetWorldObject();
    }

    Vector3 GetPositionToGenerate()
    {
        Vector3 positionToGenerate = _objectGenerated.transform.GetChild(0).transform.position;
       
        return positionToGenerate;
    }

    void Timer()
    {
        if (_generationCooldown <= 0)
        {
            Generate();
            _generationCooldown = _timerDuration;
        }
    }

    public void EndTimer()
    {
        _timerDuration = Mathf.Infinity;
    }

    // private void IncreaseTimerDuration()
    // {
    //     _timerDuration -= Time.deltaTime * _generationSpeedFactor;
    // }
}
