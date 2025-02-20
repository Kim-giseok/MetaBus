using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnter : MonoBehaviour
{
    [SerializeField] string gameName;
    [SerializeField] Vector2 enterPoint;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EnterPoint.enterPoint = enterPoint;
            SceneManager.LoadScene(gameName);
        }
    }
}
