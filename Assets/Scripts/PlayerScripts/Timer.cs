using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = startTime.ToString("f2");
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        // timerText.text = startTime.ToString("f2");
        timerText.text = (((Mathf.Floor(startTime / 60f)) % 60).ToString("00"))
             + ":" + (Mathf.Floor(startTime % 60f).ToString("00"));
    }
}
