using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : BaseUI
{
    TextMeshProUGUI scoreTxt;
    protected override UIState GetUIState() => UIState.Game;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        scoreTxt = transform.Find("ScoreTxt").GetComponent<TextMeshProUGUI>();
    }

    public void SetUI(int score)
    {
        scoreTxt.text = score.ToString();
    }
}
