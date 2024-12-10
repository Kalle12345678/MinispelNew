using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button resetHighScoreButton;
    public Button restartGameButton;

    private IButtonAction resetHighScoreAction;
    private IButtonAction restartGameAction;

    private void Start()
    {
        resetHighScoreAction = GetComponent<ResetHighScoreAction>();
        restartGameAction = GetComponent<RestartGameAction>();

        if (resetHighScoreButton != null && resetHighScoreAction != null)
        {
            resetHighScoreButton.onClick.AddListener(() => resetHighScoreAction.PerformAction());
        }

        if (restartGameButton != null && restartGameAction != null)
        {
            restartGameButton.onClick.AddListener(() => restartGameAction.PerformAction());
        }
    }
}
