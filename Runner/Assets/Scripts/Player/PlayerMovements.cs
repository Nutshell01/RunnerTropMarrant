using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Transform[] transforms;
    private bool _right;

    public float jumpForce;
    Rigidbody rb;
    //GroundCheck groundCheck;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //groundCheck = GetComponentInChildren<GroundCheck>();
    }
    private void Update()
    {
        Movements();
   
    }

    public void Movements()
    {
        if()
        
    }

    public void Jump()
    {
        Vector3 jumpforce = new Vector3(0, jumpForce, 0);


    }

    public void SetRightBool(bool boolToSet)
    {
        _right = boolToSet;
    }
}
