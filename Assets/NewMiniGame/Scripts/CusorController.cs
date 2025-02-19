using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CusorController : MonoBehaviour
{
    Camera camera;

    void Start()
    {
        camera = Camera.main;
    }

    void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);

        transform.position = worldPos;
    }
}
