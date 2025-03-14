using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    Camera mainCamera;

    [SerializeField] protected Transform ridePivot;
    [SerializeField] RideController ridePrefeb;
    RideController rideHandler;

    float baseSpeed;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        mainCamera = Camera.main;
        baseSpeed = statHanddler.Speed;
        transform.position = EnterPoint.enterPoint;
    }

    void OnMove(InputValue inputValue)
    {
        moveDir = inputValue.Get<Vector2>();
        lookDir = moveDir.magnitude >= 1 ? moveDir : lookDir;
        moveDir = moveDir.normalized;
    }

    void OnFire(InputValue inputValue)
    {
        if (!inputValue.isPressed||EventSystem.current.IsPointerOverGameObject())
            return;

        if (rideHandler == null)
        {
            if (ridePrefeb == null)
                return;

            rideHandler = Instantiate(ridePrefeb, ridePivot);
            rideHandler.Init(lookDir);

            statHanddler.Speed = rideHandler.GetComponent<StatHandler>().Speed;
            characterRenderer.transform.localPosition += ridePivot.localPosition;
        }
        else
        {
            Destroy(rideHandler.gameObject);
            statHanddler.Speed = baseSpeed;
            characterRenderer.transform.localPosition -= ridePivot.localPosition;
        }
        animHandller.RideOn();
    }
}
