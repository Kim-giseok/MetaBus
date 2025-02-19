using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RideController : BaseController
{
    protected override void FixedUpdate()
    { }

    void OnMove(InputValue inputValue)
    {
        lookDir = inputValue.Get<Vector2>().magnitude >= 1 ? inputValue.Get<Vector2>() : lookDir;
        animHandller.Move(lookDir);
    }
}
