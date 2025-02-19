using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResource : MonoBehaviour
{
    SpriteRenderer sprite;
    [SerializeField] Slider RedSlider;
    [SerializeField] Slider GreenSlider;
    [SerializeField] Slider BlueSlider;

    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        RedSlider.onValueChanged.AddListener(delegate { ColorChange(); });
        GreenSlider.onValueChanged.AddListener(delegate { ColorChange(); });
        BlueSlider.onValueChanged.AddListener(delegate { ColorChange(); });
    }

    public void ColorChange()
    {
        sprite.color = new Color(RedSlider.value, GreenSlider.value, BlueSlider.value);
    }
}
