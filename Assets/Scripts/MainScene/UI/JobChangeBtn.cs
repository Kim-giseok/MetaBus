using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobChangeBtn : MonoBehaviour
{
    [SerializeField] AnimatorOverrideController anim;
    [SerializeField] AnimationClip idle, move;

    public void ChangeJob()
    {
        anim["Idle"] = idle;
        anim["Move"] = move;
    }
}
