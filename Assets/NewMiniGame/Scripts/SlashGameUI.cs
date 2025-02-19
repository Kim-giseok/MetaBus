using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlashGameUI : GameUI
{
    Slider timeSlider;
    // Start is called before the first frame update
    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        timeSlider = transform.Find("TimeUI").GetComponentInChildren<Slider>();
    }

    public void SetTimeUI(int time)
    {
        timeSlider.value = time;
    }
}
