using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D _rig;

    [SerializeField] protected SpriteRenderer characterRenderer;

    protected Vector2 moveDir = Vector2.zero;
    public Vector2 MoveDir => moveDir;

    protected Vector2 lookDir = Vector2.zero;
    public Vector2 LookDir => lookDir;

    protected AnimationHandler animHandller;
    protected StatHandler statHanddler;

    protected virtual void Awake()
    {
        _rig = GetComponent<Rigidbody2D>();
        animHandller = GetComponent<AnimationHandler>();
        statHanddler = GetComponent<StatHandler>();
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        HandleAction();
        Rotate(lookDir);
    }
    protected virtual void FixedUpdate()
    {
        Movement(moveDir);
    }

    protected virtual void HandleAction()
    {

    }

    protected virtual void Movement(Vector2 dir)
    {
        if (statHanddler != null)
            dir *= statHanddler.Speed;

        if (_rig != null)
            _rig.velocity = dir;
        animHandller.Move(dir);
    }

    void Rotate(Vector2 dir)
    {
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        bool isL = Mathf.Abs(rotZ) > 90f;

        characterRenderer.flipX = isL;
    }
}
