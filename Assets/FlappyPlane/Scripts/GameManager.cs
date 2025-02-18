using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager GM;
    public static GameManager instance { get => GM; }

    int currentScore = 0;
    public int CurrentScore => currentScore;

    int bestScore;
    public int BestScore => bestScore;
    const string BestScoreKey = "BestScore";

    UIManager UM;
    public UIManager UIManager { get => UM; }

    private void Awake()
    {
        GM = this;
        UM = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        Time.timeScale = 0f;
        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        UM.SetScoreUI();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        bestScore = bestScore < currentScore ? currentScore : bestScore;
        PlayerPrefs.SetInt(BestScoreKey, bestScore);

        UM.UpdateScore();
        Debug.Log("Score : " + currentScore);
    }
}
