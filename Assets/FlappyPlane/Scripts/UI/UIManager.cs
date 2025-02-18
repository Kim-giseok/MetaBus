using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public enum UIState
{
    Home, Game, Score,
}

public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public static UIManager Instance { get => instance; }

    UIState currrentStat = UIState.Home;
    HomeUI homeUI = null;
    GameUI gameUI = null;
    ScoreUI scoreUI = null;

    private void Awake()
    {
        instance = this;


        homeUI = GetComponentInChildren<HomeUI>(true);
        homeUI?.Init(this);

        gameUI = GetComponentInChildren<GameUI>(true);
        gameUI?.Init(this);

        scoreUI = GetComponentInChildren<ScoreUI>(true);
        scoreUI?.Init(this);

        ChangeState(UIState.Home);
    }

    public void ChangeState(UIState state)
    {
        currrentStat = state;
        homeUI?.SetActive(currrentStat);
        gameUI?.SetActive(currrentStat);
        scoreUI?.SetActive(currrentStat);
    }

    public void OnClickStart()
    {
        ChangeState(UIState.Game);
        Time.timeScale = 1f;
    }

    public void OnClickExit()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void UpdateScore()
    {
        gameUI.SetUI(GameManager.instance.CurrentScore);
    }

    public void SetScoreUI()
    {
        scoreUI.SetUI(GameManager.instance.CurrentScore, GameManager.instance.CurrentScore);
        ChangeState(UIState.Score);
    }
}
