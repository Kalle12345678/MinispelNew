using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    ScoreManager scoreManager;
    public void SaveHighScore(int score)
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        if (scoreManager.score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore");
    }
    
}
