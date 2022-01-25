using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    //[SerializeField] Transform _positionToGenerate;
    [SerializeField] PullingManager _pullingManager;
    [SerializeField] GameObject _objectGenerated;

    [SerializeField] float _timerDuration;
    private float _generationCooldown;
    // Start is called before the first frame update

    private void Awake()
    {
        _objectGenerated = GameObject.FindGameObjectWithTag("Generated");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _generationCooldown -= Time.deltaTime;
        Timer();
    }
    void Generate()
    {
        GetPositionToGenerate();
        int RandomInt = Random.Range(0, _pullingManager._prefabsToInstantiate.Length);
        GameObject _objectToGenerate = _pullingManager._prefabsToInstantiate[RandomInt];


        GameObject objectGenerated = GameObject.Instantiate(_objectToGenerate, GetPositionToGenerate(), Quaternion.identity);

        _objectGenerated = objectGenerated;
    }

    Vector3 GetPositionToGenerate()
    {
        Vector3 positionToGenerate = _objectGenerated.transform.GetChild(0).gameObject.transform.GetChild(0).transform.position;
        Debug.Log(_objectGenerated.transform.GetChild(0).gameObject.transform.GetChild(0).name);
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
}
