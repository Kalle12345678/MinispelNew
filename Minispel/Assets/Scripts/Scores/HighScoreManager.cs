using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public void SaveHighScore(int score)
    {
        int highScore = PlayerPrefs.GetInt("HighScore");

        //Om nuvarande score är högre än tidigare, spara nuvarande som highscore
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