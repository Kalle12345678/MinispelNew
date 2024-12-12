using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Buttons : MonoBehaviour
{
    public DeathScore deathScore;

    public void RestartGameButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ResetHighscore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        deathScore.Start();
    }
}