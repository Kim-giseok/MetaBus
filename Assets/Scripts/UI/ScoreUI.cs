using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : BaseUI
{
    TextMeshProUGUI scoreTxt, bestScoreTxt;
    Button startBtn, exitBtn;

    protected override UIState GetUIState() => UIState.Score;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        scoreTxt = transform.Find("ScoreTxt").GetComponent<TextMeshProUGUI>();
        bestScoreTxt = transform.Find("BestScoreTxt").GetComponent<TextMeshProUGUI>();

        startBtn = transform.Find("StartBtn").GetComponent<Button>();
        exitBtn = transform.Find("ExitBtn").GetComponent<Button>();

        startBtn?.onClick.AddListener(OnClickStartBtn);
        exitBtn?.onClick.AddListener(OnClickExitBtn);
    }

    public void SetUI(int score, int bestScore)
    {
        scoreTxt.text = score.ToString();
        bestScoreTxt.text = bestScore.ToString();
    }

    void OnClickStartBtn()
    {
        GameManager.instance.RestartGame();
    }

    void OnClickExitBtn()
    {
        UIM.OnClickExit();
    }
}
