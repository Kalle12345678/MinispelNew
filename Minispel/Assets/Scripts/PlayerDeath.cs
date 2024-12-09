using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            scoreManager.SaveScore();
            Destroy(gameObject);
            SceneManager.LoadScene("DeathScreen");
        }
    }
}
