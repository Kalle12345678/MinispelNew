using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int scoreValue = 100;

    //Om "coin" nuddar spelaren lägg till poäng och spara, sedan ta bort "coin"
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager scoreManager = GameObject.FindObjectOfType<ScoreManager>();

            scoreManager.AddScore(scoreValue);
            scoreManager.SaveScore();

            Destroy(gameObject);
        }
    }
}
