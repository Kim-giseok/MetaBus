using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager GM;
    public static GameManager instance { get => GM; }

    int currentScore = 0;

    UIManager UM;
    public UIManager UIManager { get => UM; }

    private void Awake()
    {
        GM = this;
        UM = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        UM.UpdateScore(0);
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        UM.SetRestart();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        UM.UpdateScore(currentScore);
        UM.UpdateScore(currentScore);
        Debug.Log("Score : " + currentScore);
    }
}
