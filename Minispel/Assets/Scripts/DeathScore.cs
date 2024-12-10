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

    void Start()
    {
        highScoreManager.GetHighScore();

        //Tar fram score från "playerPrefs"
        int currentScore = PlayerPrefs.GetInt("PlayerScore");
        int highScore = PlayerPrefs.GetInt("HighScoreKey");

        //Skriver ut i canvasen: score och highscore
        currentScoreText.text = "Score: " + currentScore;
        highScoreText.text = "HighScore: " + highScoreManager.GetHighScore();
    }
}
