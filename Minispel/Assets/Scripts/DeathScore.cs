using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI currentScoreText;
    public HighScoreManager highScoreManager;

    private void Start()
    {
        int currentScore = PlayerPrefs.GetInt("PlayerScore", 1);
        int highScore = PlayerPrefs.GetInt("HighScoreKey", 2);

        currentScoreText.text = "Score: " + currentScore;
        highScoreText.text = "HighScore: " + highScoreManager.GetHighScore();
    }
}
