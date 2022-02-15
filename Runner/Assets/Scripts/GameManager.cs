using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _worldSpeed;
    [SerializeField] float _accelerationFactor;
    [SerializeField] AnimationCurve _accelerationCurve;
    private GameObject[] _worldObject;
    private float _distance;
    public int _collectibleNumber;

    #region Unity Methodes
    private void Start()
    {
        _worldObject = GameObject.FindGameObjectsWithTag("Generated");
    }

    private void FixedUpdate()
    {

        foreach (GameObject worldObj in _worldObject)
        {
            if (worldObj != null)
                worldObj.transform.position += -transform.forward * _worldSpeed * Time.fixedDeltaTime;
        }
    }
    private void Update()
    {
        IncreaseScore();
        
       _worldSpeed = _accelerationCurve.Evaluate(Time.time);
      
    }

    #endregion

    #region Score
    private void IncreaseScore()
    {
        _distance += Time.deltaTime * _worldSpeed;
    }

    public int GetScore()
    {
        int finalScore;
        finalScore = Mathf.RoundToInt(_distance) * (_collectibleNumber / 100);
        return finalScore;
    }

    #endregion

    public void GetWorldObject()
    {
        _worldObject = GameObject.FindGameObjectsWithTag("Generated");
    }

    // void IncreaseWorldSpeed()
    // {
    //     _worldSpeed += _accelerationFactor * Time.deltaTime;
    // }

    public int GetCollectibleNumber()
    {
        return _collectibleNumber;
    }
    public void SetCollectibleNumber(int coinValue)
    {
        _collectibleNumber += coinValue;
    }

}
