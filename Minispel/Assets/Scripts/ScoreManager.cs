using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour, IScore
{
    private int score = 0;

    [SerializeField] private TextMeshProUGUI scoreText;
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }

    private void Start()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
