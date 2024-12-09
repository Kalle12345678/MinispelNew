using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreValue = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindAnyObjectByType<ScoreManager>();
            scoreManager.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
