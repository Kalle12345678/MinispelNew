using UnityEngine;

public class ResetHighScoreAction : MonoBehaviour, IButtonAction
{
    public void PerformAction()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        Debug.Log("High Score reset to 0.");
    }
}
