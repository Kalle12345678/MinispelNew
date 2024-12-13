using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Buttons : MonoBehaviour
{
    public DeathScore deathScore;

    //Laddar mainscenen p� knapptryck
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }

    //Resettar highscore p� knapptryck
    public void ResetHighscore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        deathScore.Start();
    }

    //St�nger ner spelet p� knapptryck
    public void OnQuit()
    {
        Application.Quit();
    }

    public interface IQuitGame
    {
        void OnQuit();
    }

    public interface IResetHighscore
    {
        void ResetHighscore();
    }

    public interface IRestartGame
    {
        void Restart();
    }

}