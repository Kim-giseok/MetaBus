using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResource : MonoBehaviour
{
    SpriteRenderer sprite;
    StatHandler stat;

    private void Awake()
    {
        stat = GetComponent<StatHandler>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sprite.color = new Color(stat.Red, stat.Green, stat.Blue);
    }
}
