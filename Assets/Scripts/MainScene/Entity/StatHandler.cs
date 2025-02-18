using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatHandler : MonoBehaviour
{
    [Range(1, 100)][SerializeField] int health = 10;
    public int Health
    {
        get => health;
        set => health = Mathf.Clamp(value, 0, 100);
    }

    [Range(1, 100)][SerializeField] float speed = 3;
    public float Speed
    {
        get => speed;
        set => speed = Mathf.Clamp(value, 0, 20);         
    }

    [Range(0, 255)][SerializeField] int red = 255;
    public int Red
    {
        get => red;
        set => red = Mathf.Clamp(value, 0, 255);
    }
    [Range(0, 255)][SerializeField] int green = 255;
    public int Green
    {
        get => green;
        set => green = Mathf.Clamp(value, 0, 255);
    }
    [Range(0, 255)][SerializeField] int blue = 255;
    public int Blue
    {
        get => blue;
        set => blue = Mathf.Clamp(value, 0, 255);
    }
}
