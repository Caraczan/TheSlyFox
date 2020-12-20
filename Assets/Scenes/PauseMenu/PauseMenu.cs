using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject BackgroundMenu;

    [SerializeField] private bool isPaused;


    // Start is called before the first frame update
    void ResumeGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); przerobić by wczytywał aktualny lvl
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                ActivateMenu();
            }

            else
            {
                DeactivateMenu();
            }
        }

        
    }
    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
        BackgroundMenu.SetActive(true);
    }
    void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
        BackgroundMenu.SetActive(false);
    }
}
