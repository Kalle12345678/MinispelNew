using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int currentScore;

    public void AddScore(int score)
    {
        currentScore += score;
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("PlayerScore", currentScore);
        HighScoreManager highScoreManager = FindObjectOfType<HighScoreManager>();
        if (highScoreManager != null)
        {
            highScoreManager.SaveHighScore(currentScore);
        }
        PlayerPrefs.Save();
    }

}