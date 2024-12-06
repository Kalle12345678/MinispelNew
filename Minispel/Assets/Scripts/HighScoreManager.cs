using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    private const string HighScoreKey = "HighScore";

    public void SaveHighScore(int score)
    {
        int highScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        if(score > highScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score);
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(HighScoreKey, 0);
    }
}
