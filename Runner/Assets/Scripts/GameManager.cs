using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] float _worldSpeed;
    [SerializeField] float _accelerationFactor;
    [SerializeField] AnimationCurve _accelerationCurve;
    [SerializeField] TextMeshProUGUI _coinText;
    [SerializeField] TextMeshProUGUI _scoreText;
    private GameObject[] _worldObject;
    public bool _isDead = false;
    private float _distance;
    private int _collectibleNumber;

    #region Unity Methodes
    private void Start()
    {
        _worldObject = GameObject.FindGameObjectsWithTag("Generated");
        _worldSpeed = 3;
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
        _coinText.text = _collectibleNumber.ToString();
        if (_isDead == false)
        {
            _worldSpeed = _accelerationCurve.Evaluate(Time.timeSinceLevelLoad);
        }
        else
        {
            _worldSpeed = 0;
        }

        _scoreText.text = GetScore().ToString();

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
        finalScore = Mathf.RoundToInt(_distance * _collectibleNumber);
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
