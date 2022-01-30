using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] private PlayerMovements playerMovements = null;

    
    private void Update()
    {
        OnJump();
        OnSlide();
        GoRight();
        GoLeft();

    }

    public void OnJump()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            playerMovements.Jump();
            Debug.Log("ok");
        }
    }

    public void OnSlide()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

        }

    }

    public void GoRight()
    {
        
        //playerMovements.SetRightBool(Input.GetButtonDown("Right"));

    }

    public void GoLeft()
    {
        if (Input.GetButtonDown("Left"))
        {

        }

    }


}
