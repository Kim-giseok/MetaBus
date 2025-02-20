using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResource : MonoBehaviour
{
    SpriteRenderer sprite;
    Color playerColor = new Color(1, 1, 1);

    [Serializable]
    public struct AnimSet
    {
        public AnimationClip idle;
        public AnimationClip move;
    }
    [SerializeField] AnimSet[] animSets;
    [SerializeField] AnimatorOverrideController anim;

    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    public void ChangeRed(Slider red)
    {
        playerColor.r = red.value;
        ColorChange();
    }
    public void ChangeGreen(Slider green)
    {
        playerColor.g = green.value;
        ColorChange();
    }
    public void ChangeBlue(Slider blue)
    {
        playerColor.b = blue.value;
        ColorChange();
    }

    void ColorChange()
    {
        sprite.color = playerColor;
    }

    public void ChangeJob(int idx)
    {
        anim["Idle"] = animSets[idx].idle;
        anim["Move"] = animSets[idx].move;
    }
}
