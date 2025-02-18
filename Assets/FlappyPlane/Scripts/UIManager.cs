using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI restartTxt;
    public Image ReadyImg;

    public void Start()
    {
        if (restartTxt == null)
        {
            Debug.LogError("restart text is null");
        }

        if (scoreTxt == null)
        {
            Debug.LogError("scoreText is null");
            return;
        }

        if (ReadyImg == null)
        {
            Debug.LogError("readyImg is null");
            return;
        }

        ReadyImg.gameObject.SetActive(true);
        restartTxt.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        restartTxt.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreTxt.text = score.ToString();
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        ReadyImg.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}