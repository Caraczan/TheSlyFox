using System;
using System.Collections;
using System.Collections.Generic;
using PlayerScripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    private String _currentScene;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = startTime.ToString("f2");
        _currentScene = SceneManager.GetActiveScene().name;
        PlayerData.player_level_time_completion.Add(_currentScene, "0");
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        // timerText.text = startTime.ToString("f2");
        timerText.text = (((Mathf.Floor(startTime / 60f)) % 60).ToString("00"))
                + ":" + (Mathf.Floor(startTime % 60f).ToString("00"))
             + ":" + (((((startTime % 1f)) * 1000).ToString("00")));
        
        // po co ??
        // PlayerPrefs.SetString("Times", "00");
        // PlayerPrefs.Save();
        PlayerData.player_level_time_completion[_currentScene] = timerText.text;
    }

}
