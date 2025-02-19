using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RideController : BaseController
{
    public void Init(Vector2 lookDir)
    {
        this.lookDir = lookDir;
    }

    protected virtual void FixedUpdate()
    {
    }

    void OnMove(InputValue inputValue)
    {
        lookDir = inputValue.Get<Vector2>().magnitude >= 1 ? inputValue.Get<Vector2>() : lookDir;
        animHandller.Move(inputValue.Get<Vector2>().normalized);
    }
}
