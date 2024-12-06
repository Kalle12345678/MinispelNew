using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;
    public ScoreManager scoreManager;
    public HighScoreManager highScoreManager;

    private void Update()
    {
        currentScoreText.text = "Score: " + scoreManager.currentScore;
        highScoreText.text = "High Score: " + highScoreManager.GetHighScore();
    }
}