using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    Button startBtn;

    protected override UIState GetUIState() => UIState.Home;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        startBtn = transform.Find("StartBtn").GetComponent<Button>();

        startBtn.onClick.AddListener(OnClickStartBtn);
    }

    void OnClickStartBtn()
    {
        UIM.OnClickStart();
    }
}
