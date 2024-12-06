using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text currentScoreText;
    public Text highScoreText;
    public ScoreManager scoreManager;
    public HighScoreManager highScoreManager;

    private void Update()
    {
        currentScoreText.text = "Score: " + scoreManager.currentScore;
        highScoreText.text = "High Score: " + highScoreManager.GetHighScore();
    }
}