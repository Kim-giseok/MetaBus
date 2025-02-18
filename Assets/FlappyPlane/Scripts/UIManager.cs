using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI restartTxt;

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
}