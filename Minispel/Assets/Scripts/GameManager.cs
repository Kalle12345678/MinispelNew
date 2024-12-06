using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public HighScoreManager highScoreManager;

    private void EndGame()
    {
        int finalScore = scoreManager.currentScore;
        highScoreManager.SaveHighScore(finalScore);

        Debug.Log("Game Over! Final Score: " + finalScore);
        Debug.Log("High Score: " + highScoreManager.GetHighScore());
    }
}
