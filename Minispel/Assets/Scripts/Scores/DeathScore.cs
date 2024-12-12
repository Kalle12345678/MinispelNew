using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathScore : MonoBehaviour
{
    public HighScoreManager highScoreManager;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;

    public void Start()
    {
        //Tar fram score från "playerPrefs"
        int currentScore = PlayerPrefs.GetInt("PlayerScore");
        int highScore = PlayerPrefs.GetInt("HighScoreKey");

        //Skriver ut i canvasen: score och highscore
        currentScoreText.text = "Score: " + currentScore;
        highScoreText.text = "HighScore: " + highScoreManager.GetHighScore();
    }
}
