using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void GoTo1Intro()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void GoTo2HighScores()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void GoTo3Game()
    {
        SceneManager.LoadScene("3Game");
    }

    public void GoTo4Exit()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void QuitGame()
    {
        //exit application for real:
        // Application.Quit();

        // for development:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
