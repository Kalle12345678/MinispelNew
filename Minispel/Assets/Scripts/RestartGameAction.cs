using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameAction : MonoBehaviour, IButtonAction
{
    public void PerformAction()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("Game restarted.");
    }
}
