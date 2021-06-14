using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : PauseMenuS
{
    
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    public void OptionsOn()
    {
        OptionsIsON = true;
    }
    public void OptionsOff()
    {
        OptionsIsON = false;
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
