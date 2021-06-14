using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuS : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool OptionsIsON = false;

    public GameObject pauseMenuUI;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (!GameIsPaused)
            {
                Pause();
            }
            else 
            {
                if (GameIsPaused && OptionsIsON == false)
                {
                    Resume();
                }
            }
        }
        
    }
    void Resume() 
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
