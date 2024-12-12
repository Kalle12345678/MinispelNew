using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI currentScoreText;
    public ScoreManager scoreManager;

    //Visar vad score �r just nu
    private void Update()
    {
        currentScoreText.text = "Score: " + scoreManager.currentScore;
    }
}