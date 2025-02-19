using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    static readonly int IsMoving = Animator.StringToHash("IsMove");
    static readonly int IsRide = Animator.StringToHash("IsRide");

    protected Animator anim;

    protected virtual void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        anim.SetBool(IsMoving, obj.magnitude > .5f);
    }

    public void RideOn()
    {
        anim.SetBool(IsRide, !anim.GetBool(IsRide));
    }
}
