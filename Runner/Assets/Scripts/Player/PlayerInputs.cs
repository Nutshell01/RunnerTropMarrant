using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
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
        if (Input.GetMouseButtonDown(1))
        {

        }

    }

    public void GoLeft()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }

    }


}
