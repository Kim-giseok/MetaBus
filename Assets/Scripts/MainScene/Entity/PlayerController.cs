using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    Camera mainCamera;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        mainCamera = Camera.main;
    }

    void OnMove(InputValue inputValue)
    {
        moveDir = inputValue.Get<Vector2>();
        moveDir = moveDir.normalized;
    }
}
