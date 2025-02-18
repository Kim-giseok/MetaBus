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
        UM.UpdateScore();
        Debug.Log("Score : " + currentScore);
    }
}
