using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CusorController : MonoBehaviour
{
    GameManager GM;
    Camera mainCamera;

    bool isAttack = false;

    void Start()
    {
        mainCamera = Camera.main;
        GM = GameManager.instance;
    }

    void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(mousePosition);

        transform.position = worldPos;
    }

    void OnFire(InputValue inputValue)
    {
        isAttack = inputValue.isPressed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (isAttack)
        {
            Destroy(collision.gameObject);
            GM.AddScore(1);
        }
    }
}
