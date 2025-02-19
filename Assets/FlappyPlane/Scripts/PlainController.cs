using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlainController : BaseController
{
    Animator animator;

    public float flapForce = 6f;
    public float forwordSpeed = 3f;
    public bool isDead = false;
    float deathCooldown = 0f;

    bool isFlap = false;

    public bool godMode = false;

    GameManager GM;

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponentInChildren<Animator>();
        if (animator == null)
            Debug.LogError("Not Founded Animator");

        if (_rig == null)
            Debug.LogError("Not Founded Rigidbody");
    }

    protected override void Start()
    {
        GM = GameManager.instance;
        base.Start();
    }

    protected override void HandleAction()
    {
        if (isDead)
        {
            if (deathCooldown > 0)
                deathCooldown -= Time.deltaTime;
            else
                GM.GameOver();
        }
    }

    void OnFire(InputValue inputValue)
    {
        if (!inputValue.isPressed || EventSystem.current.IsPointerOverGameObject())
            return;

        if (!isDead)
            isFlap = true;
    }

    protected override void Movement(Vector2 dir)
    {
        if (isDead) return;

        moveDir = _rig.velocity;
        moveDir.x = forwordSpeed;

        if (isFlap)
        {
            moveDir.y += flapForce;
            isFlap = false;
        }

        _rig.velocity = moveDir;

        float angle = Mathf.Clamp(_rig.velocity.y * 10, -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (godMode || isDead) return;

        isDead = true;
        deathCooldown = 1f;

        animator.SetInteger("isDie", 1);
    }
}
