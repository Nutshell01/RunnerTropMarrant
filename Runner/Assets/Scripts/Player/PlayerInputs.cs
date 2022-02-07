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
        }
    }

    public void OnSlide()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerMovements.Slide();
        }

    }

    public void GoRight()
    {

        //playerMovements.SetRightBool(Input.GetButtonDown("Right"));
        if (Input.GetButtonDown("Right"))
        {
            playerMovements.moveToRight();
        }

    }

    public void GoLeft()
    {
        if (Input.GetButtonDown("Left"))
        {
            playerMovements.moveToLeft();
        }

    }


}
