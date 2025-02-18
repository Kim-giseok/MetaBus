using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnter : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] string gameName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
            SceneManager.LoadScene(gameName);
    }
}
