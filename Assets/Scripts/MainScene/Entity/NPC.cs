using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject txt;

    void Awake()
    {
        if (txt != null)
            txt.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (txt != null && collision.gameObject.CompareTag("Player"))
            txt.SetActive(true);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (txt != null && collision.gameObject.CompareTag("Player"))
            txt.SetActive(false);
    }
}
