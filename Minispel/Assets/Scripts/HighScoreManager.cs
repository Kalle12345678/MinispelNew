using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    ScoreManager scoreManager;
    private int score;
    public void SaveHighScore(int score)
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore");
    }
    
}
