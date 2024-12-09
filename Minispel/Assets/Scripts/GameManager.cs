using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public HighScoreManager highScoreManager;

    public void EndGame()
    {
        int finalScore = scoreManager.currentScore;
        highScoreManager.GetHighScore();

        print("Game Over! Final Score: " + finalScore);
        print("High Score: " + highScoreManager.GetHighScore());
    }
}
