using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public ScoreManager scoreManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Om du nuddar en spik, spara ditt score, döda spelaren, byt scen
        if (collision.CompareTag("Spike"))
        {
            scoreManager.SaveScore();
            Destroy(gameObject);
            SceneManager.LoadScene("DeathScreen");
        }
    }
}
