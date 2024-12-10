using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathScore : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI currentScoreText;
    public HighScoreManager highScoreManager;


    private void Start()
    {
        highScoreManager.GetHighScore();

        int currentScore = PlayerPrefs.GetInt("PlayerScore");
        int highScore = PlayerPrefs.GetInt("HighScoreKey");

        currentScoreText.text = "Score: " + currentScore;
        highScoreText.text = "HighScore: " + highScoreManager.GetHighScore();
        
    }
}
