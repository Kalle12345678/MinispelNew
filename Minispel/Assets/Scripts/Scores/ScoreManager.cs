using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;

    //L�gger till score till nuvarande po�ng
    public void AddScore(int score)
    {
        currentScore += score;
    }

    //Sparar score och updaterar highscore 
    public void SaveScore()
    {
        PlayerPrefs.SetInt("PlayerScore", currentScore);
        HighScoreManager highScoreManager = FindObjectOfType<HighScoreManager>();
        highScoreManager.SaveHighScore(currentScore);
        PlayerPrefs.Save();
    }
}