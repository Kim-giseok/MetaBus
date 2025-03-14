using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CusorController : MonoBehaviour
{
    GameManager GM;
    Camera mainCamera;

    bool isAttack = false;

    [SerializeField] ParticleSystem slashParticle;
    [SerializeField] ParticleControl particleControl;

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
        if (isAttack)
            slashParticle.Play();
        else
            slashParticle.Stop();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (isAttack)
        {
            particleControl.ParitclesAtPosition(collision.transform.position);
            Destroy(collision.gameObject);
            GM.AddScore(1);
        }
    }
}
