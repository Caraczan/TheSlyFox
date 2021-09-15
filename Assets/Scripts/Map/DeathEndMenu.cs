using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathEndMenu : MonoBehaviour {
    public void BackToMenu() {
        SceneManager.LoadScene(0);
    }

    public void ExitGame() {
        Application.Quit();
    }
}
