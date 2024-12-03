using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int scoreValue = 100;

    private void OnTriggerEnter2D(Collider2D other)
    {
        IScore scoreManager = other.GetComponent<IScore>();

        if (scoreManager != null)
        {
            scoreManager.AddScore(scoreValue);

            Destroy(gameObject);
        }
    }
}
