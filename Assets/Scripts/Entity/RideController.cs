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

    protected override void FixedUpdate()
    {
        //BaseController의 Movement를 동작하지 않게 하기 위한 오버라이드 입니다.
    }

    void OnMove(InputValue inputValue)
    {
        lookDir = inputValue.Get<Vector2>().magnitude >= 1 ? inputValue.Get<Vector2>() : lookDir;
        animHandller.Move(inputValue.Get<Vector2>().normalized);
    }
}
