using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI currentScoreText;
    public ScoreManager scoreManager;

    private void Update()
    {
        currentScoreText.text = "Score: " + scoreManager.currentScore;
    }
}